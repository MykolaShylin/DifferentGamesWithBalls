namespace BallGameWinFormsLibrary
{
    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHeated;
        public BillyardBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();
            ChangeBallDirection();
        }
        protected virtual void ChangeBallDirection()
        {
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHeated.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHeated.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHeated.Invoke(this, new HitEventArgs(Side.Dowm));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHeated.Invoke(this, new HitEventArgs(Side.Top));
            }
        }

        
    }
}
