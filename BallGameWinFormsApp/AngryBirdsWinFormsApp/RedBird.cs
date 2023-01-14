
using BallGameWinFormsLibrary;

namespace AngryBirdsWinFormsApp
{
    public class RedBird : Ball
    {
        public event EventHandler<HitEventArgs> OnHeated;
        public event EventHandler<HitEventArgs> HitTheBarrier;
        protected float g = 0.2f;
        protected float frictionForce = 2;
        protected float birdJumpHeight;
        protected int birdRadius = 20;
        protected float mouseX;
        protected float mouseY;
        protected bool isGravityActivated = false;
        protected int speed;
        protected List<Pig> pigs;
        protected Brush brush = Brushes.Red;
        protected float constantX;
        protected float constantY;
        protected bool isSpeedUp = false;
        private MetallBarrier barrier;
        public RedBird(Form form) : base(form)
        {
            radius = birdRadius;
            centerX = radius;
            centerY = DownSide();
        }
        public RedBird(Form form, float mouseX, float mouseY, List<Pig> pigs) : base(form)
        {
            speed = timer.Interval;
            this.mouseX = mouseX;
            this.mouseY = mouseY;
            radius = birdRadius;
            centerX = radius;
            centerY = DownSide();
            vx = mouseX / speed * g;
            vy = -((centerY - mouseY) / speed) * g;
            birdJumpHeight = vy;
            this.pigs = pigs;
        }
        public void IsKilledPig()
        {
            for (int i = 0; i < pigs.Count; i++)
            {
                int pigX = (int)pigs[i].GetX();
                int pigY = (int)pigs[i].GetY();
                int pigRadius = pigs[i].GetRadius();
                var radiusSum = radius + pigRadius;
                var distanceBetweenBall = Math.Sqrt(Math.Abs(Math.Pow(centerX - pigX, 2) + Math.Pow(centerY - pigY, 2)));
                if (distanceBetweenBall <= radiusSum)
                {
                    pigs[i].Clear();
                    pigs.RemoveAt(i);
                    OnHeated.Invoke(this, null);

                }
            }
        }
        protected override void Go()
        {
            base.Go();

            if (!isSpeedUp)
            {
                constantX = vx;
                constantY = vy;
                ChangeGravity();
                ChangeBirdAmplitude();
            }
        }
        protected void ChangeBirdAmplitude()
        {
            if (centerY >= DownSide())
            {
                birdJumpHeight += frictionForce;
                if (birdJumpHeight >= 0)
                {
                    vx -= 0.1f;
                    vy = 0;
                    g = 0;
                }
                else
                {
                    vy = birdJumpHeight;
                }
            }
        }
        public bool IsBirdStoped()
        {
            return vx <= 0 && vy == 0;
        }

        public override void Show()
        {

            HideOrShow(brush);
        }

        private void ChangeGravity()
        {
            if (centerX >= mouseX && centerY >= mouseY)
            {
                isGravityActivated = true;
            }
            else
            {
                vy += 0.05f;
            }
            if (isGravityActivated)
            {
                vy += g;
            }
        }

        public bool IsBirdOutSide()
        {
            return centerX >= RightSide() || centerY >= DownSide() && isSpeedUp || centerX < 0;
        }
        public void SizeUp()
        {
            radius *= 2;
        }
        public override void SpeedUp()
        {
            vx = constantX * 2;
            vy = constantY * 2;
            isSpeedUp = true;
        }
        public bool WasFallen()
        {
            return centerY > DownSide();
        }

        public void IsHitTheBarrier(MetallBarrier barrier)
        {
            this.barrier = barrier;
            var barrierX = barrier.GetX();
            var barrierY = barrier.GetY();
            var barrierWidth = barrier.GetWidth();
            var barrierHeight = barrier.GetHeight();

            var currentBirdX = centerX;
            var currentBirdY = centerY;

            if (centerX + radius < barrierX)
            {
                currentBirdX = barrierX;
            }
            else if (centerX - radius > barrierX + barrierWidth)
            {
                currentBirdX = barrierX + barrierWidth;
            }

            if (centerY + radius < barrierY)
            {
                currentBirdY = barrierY;
            }
            else if (centerY - radius > barrierY + barrierHeight)
            {
                currentBirdY = barrierY + barrierHeight;
            }
            if (Math.Pow(centerX - currentBirdX, 2) + Math.Pow(centerY - currentBirdY, 2) <= Math.Pow(radius, 2))
            {
                if (barrier is WaterBarrier)
                {
                    HitTheBarrier.Invoke(this, null);
                }
                else
                {
                    if (currentBirdY - radius <= barrierY + barrierHeight && currentBirdY - radius > barrierY && currentBirdY + radius > barrierY + barrierHeight && vy < 0)
                    {
                        HitTheBarrier.Invoke(this, new HitEventArgs(Side.Dowm));
                    }
                    else if (currentBirdY + radius < barrierY + barrierHeight / 10 && vy > 0)
                    {
                        HitTheBarrier.Invoke(this, new HitEventArgs(Side.Top));
                    }
                    else
                    {
                        HitTheBarrier.Invoke(this, new HitEventArgs(Side.Left));
                    }
                }
            }
        }
        public void SlowBird()
        {
            vx /= 4;
            vy /= 4;
            if(birdJumpHeight < vx / 2)
            {
                frictionForce *= 3f;
            }
            else
            {
                frictionForce *= 1.5f;
            }
        }

        public void DowmHit()
        {
            vy = -vy;
            birdJumpHeight += frictionForce;
        }

        public void TopHit()
        {
            vy = -vy;
            birdJumpHeight += frictionForce;
        }
        public void LeftHit()
        {
            vx = -vx;
            birdJumpHeight += frictionForce;
        }
    }
}
