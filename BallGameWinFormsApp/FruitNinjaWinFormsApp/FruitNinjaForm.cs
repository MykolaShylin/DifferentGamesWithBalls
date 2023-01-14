using BallGameWinFormsLibrary;

namespace FruitNinjaWinFormsApp
{
    public partial class FruitNinjaForm : Form
    {
        List<Ball> fruits;
        Random random = new Random();
        int timer;

        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            newGame();
        }
        private void newGame()
        {
            startButton.Enabled = false;
            fruits = new List<Ball>();
            gameTimer.Start();
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            var fruit = GetFruitType();
            fruits.Add(fruit);
            fruit.Start();
            if(sleepTimer.Enabled)
            {
                fruit.SlowDown();
            }
        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (fruits != null)
            {
                for (int i = 0; i < fruits.Count; i++)
                {
                    if (fruits[i].IsMousePointOnBall(e.X, e.Y) && fruits[i].GetType() != typeof(BombFruit) && fruits[i].GetType() != typeof(BananaFruit))
                    {
                        CutFruit(fruits[i], i);
                    }
                    else if (fruits[i].IsMousePointOnBall(e.X, e.Y) && fruits[i] is BombFruit)
                    {
                        EndGame();
                        return;
                    }
                    else if (fruits[i].IsMousePointOnBall(e.X, e.Y) && fruits[i] is BananaFruit)
                    {
                        CutFruit(fruits[i], i);
                        for (int j = 0; j < fruits.Count; j++)
                        {
                            fruits[j].SlowDown();
                        }                        
                        timer = 3;
                        sleepTimer.Start();
                    }
                }
            }
        }
        private Ball GetFruitType()
        {
            var fruitOrBomb = random.Next(1, 11);
            if (fruitOrBomb < 3)
            {
                var bananaOrBomb = random.Next(1, 3);
                if (bananaOrBomb == 1)
                {
                    return new BombFruit(this);
                }
                return new BananaFruit(this);
            }
            return new FruitNinja(this);
        }
        private void CutFruit(Ball fruit, int index)
        {
            fruit.Stop();
            fruit.Clear();
            fruits.RemoveAt(index);
        }
        private void EndGame()
        {
            gameTimer.Stop();            
            for (int i = 0; i < fruits.Count(); i++)
            {
                fruits[i].Stop();
                fruits[i].Clear();
            }
            fruits.Clear();
            startButton.Enabled = true;
            MessageBox.Show("Игры окончена, вы все взорвали!", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sleepTimer_Tick(object sender, EventArgs e)
        {
            timer--;
            if(timer == 0)
            {
                sleepTimer.Stop();
                for (int j = 0; j < fruits.Count; j++)
                {
                    fruits[j].SpeedUp();
                }
            }
        }
    }
}