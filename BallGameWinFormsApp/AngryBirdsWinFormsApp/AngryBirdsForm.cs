using BallGameWinFormsLibrary;
using System.Threading;

namespace AngryBirdsWinFormsApp
{
    public partial class AngryBirdsForm : Form
    {
        private MetallBarrier barrier;
        private RedBird bird;
        private List<Pig> pigs;
        private int pigCount;
        private int birdCount;
        private Random random = new Random();
        private bool fallenOnce = false;
        private bool isSpeedUpActivated = false;
        private bool isBirdHitTheBarrier = false;
        public AngryBirdsForm()
        {
            InitializeComponent();
        }

        private void AngryBirdsForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание, правила игры: " +
                "\n1) В нижнем левом углу появляются шарики птицы (шарики разного цвета), при нажатии на поле в случайном месте он взлетает (чем дальше клик - тем сильнее вылет);" +
                "\n2) Красная птица - обычная, синяя птица - при клике на поле в любом месте - ускоряется в 2 раза и потом взрывается, черная птица - при клике на поле в любом месте - увеличивается в 2 раза;" +
                "\n3) В случайных местах, на поле, появляются свиньи (шарики зеленого цвет). Ваша задача - сбить их птицами;" +
                "\n4) На поле присутствуют барьеры различного типа: серый - металлический - птица отскакивает от него, водяной - замедляет и уменьшает дальность полета птицы!" +
                "\n5) Количество птиц отображается в левом верхнем углу. Если потратите всех, а свиньи остануться, то игра будет окончена!",
                "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void birdFlyTimer_Tick(object sender, EventArgs e)
        {
            bird.IsKilledPig();
            if(!isBirdHitTheBarrier)
            {
                bird.IsHitTheBarrier(barrier);
            }
            if (bird.WasFallen())
            {
                fallenOnce = true;
            }
            if (bird.IsBirdStoped() || bird.IsBirdOutSide() || isSpeedUpActivated && bird.WasFallen())
            {
                NewBird();
            }
        }

        private void AngryBirdsForm_MouseClick(object sender, MouseEventArgs e)
        {            
            if (birdFlyTimer.Enabled == false && startButton.Enabled == false)
            {
                switch(bird)
                {
                    case BlackBird:
                        bird = new BlackBird(this, e.X, e.Y, pigs);
                        break;
                    case BlueBird:
                        bird = new BlueBird(this, e.X, e.Y, pigs);
                        break;
                    default:
                        bird = new RedBird(this, e.X, e.Y, pigs);
                        break;
                }
                bird.OnHeated += Bird_OnHeated;
                bird.HitTheBarrier += Bird_HitTheBarrier;
                bird.Start();
                birdsCountLabel.Text = (Convert.ToInt32(birdsCountLabel.Text) - 1).ToString();
                birdFlyTimer.Start();
            }            
            else if(birdFlyTimer.Enabled == true)
            {
                if(bird is BlackBird)
                {
                    bird.SizeUp();
                }
                else if(bird is BlueBird && !fallenOnce)
                {
                    bird.SpeedUp();
                    isSpeedUpActivated = true;
                }
            }
        }

        private void Bird_HitTheBarrier(object? sender, HitEventArgs e)
        {
            if (e == null)
            {
                bird.SlowBird();
            }
            else
            {
                switch (e.Side)
                {
                    case Side.Left:
                        bird.LeftHit();
                        break;
                    case Side.Top:
                        bird.TopHit();
                        break;
                    case Side.Dowm:
                        bird.DowmHit();
                        break;
                }
            }
            isBirdHitTheBarrier = true;
        }

        private void Bird_OnHeated(object? sender, BallGameWinFormsLibrary.HitEventArgs e)
        {
            killCountLabel.Text = (Convert.ToInt32(killCountLabel.Text) + 1).ToString();
            if (birdCount == 0)
            {
                EndGame();
            }
            else
            {
                NewBird();
            }
        }

        private void EndGame()
        {
            MessageBox.Show($"Игра окончена, у вас закончились птицы! Вам удалось сбить {killCountLabel.Text} свиньи(-ей)");
            foreach (var pig in pigs)
            {
                pig.Clear();
            }
            pigs.Clear();
            barrier.Clear();
            barrier.Stop();
            birdFlyTimer.Stop();
            birdsCountLabel.Text = "0";
            killCountLabel.Text = "0";
            startButton.Enabled = true;
        }

        private void NewGame()
        {
            startButton.Enabled = false;
            pigCount = random.Next(2, 5);
            birdCount = pigCount;            
            pigs = new List<Pig>(pigCount);
            for (int i = 0; i < pigCount; i++)
            {
                var pig = new Pig(this);
                pigs.Add(pig);
                pig.Show();
            }
            GetBarrier();
            GetBird();
            bird.Show();
            barrier.Start();
            birdsCountLabel.Text = birdCount.ToString();
            fallenOnce = false;
            isSpeedUpActivated = false;
        }
        private void NewBird()
        {
            bird.Stop();
            bird.Clear();
            birdFlyTimer.Stop();
            if (birdsCountLabel.Text == "0")
            {
                EndGame();
                return;
            }
            GetBird();
            bird.Show();
            isSpeedUpActivated = false;
            isBirdHitTheBarrier = false;
            fallenOnce = false;
        }
        private void GetBird()
        {
            int randomBird = random.Next(1, 4);
            switch (randomBird)
            {
                case 1:
                    bird = new RedBird(this);
                    break;
                case 2:
                    bird = new BlackBird(this);
                    break;
                case 3:
                    bird = new BlueBird(this);
                    break;
            }
        }
        private void GetBarrier()
        {
            int randomBird = random.Next(1, 3);
            switch (randomBird)
            {
                case 1:
                    barrier = new MetallBarrier(this);
                    break;
                case 2:
                    barrier = new WaterBarrier(this);
                    break;
            }
        }

    }
}