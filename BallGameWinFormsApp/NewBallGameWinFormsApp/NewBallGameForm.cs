using BallGameWinFormsLibrary;

namespace NewBallGameWinFormsApp
{
    public partial class NewBallGameForm : Form
    {
        private List<MoveBall> moveBalls;
        private int ballsCount = 10;
        private int catchesBallsCount = 0;
        public NewBallGameForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < moveBalls.Count; i++)
            {
                if (!moveBalls[i].IsBallOnMap())
                {
                    moveBalls[i].Stop();    
                    moveBalls[i].Clear();
                    moveBalls.RemoveAt(i);
                }
                if (moveBalls.Count() == 0)
                {
                    showCatchesBallsCount();
                    timer1.Enabled = false;
                    ClearMap();
                    return;
                }
            }
        }

        private void NewBallGameForm_MouseDown(object sender, MouseEventArgs e)
        {
            UserMouseCatches(e);
        }
        private void aLotOfBallsButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
            stopMovingButton.Enabled = true;
            timer1.Enabled = true;

        }
        private void stopMovingButton_Click(object sender, EventArgs e)
        {
            stopMovingButton.Enabled = false;
            if (moveBalls != null || moveBalls.Any())
            {
                foreach (var ball in moveBalls)
                {
                    ball.Stop();
                    if (ball.IsBallOnMap())
                    {
                        catchesBallsCount++;
                    }
                }
                showCatchesBallsCount();
                ClearMap();
            }

        }
        public void ClearMap()
        {
            var graphics = CreateGraphics();
            graphics.Clear(Color.White);
            moveBalls.Clear();
            stopMovingButton.Enabled = false;
            catchesBallsCount = 0;
            catchesBallsCountLabel.Text = catchesBallsCount.ToString();
        }

        private void UserMouseCatches(MouseEventArgs e)
        {
            for (int i = 0; i < moveBalls.Count; i++)
            {
                if (moveBalls[i].IsMousePointOnBall(e.X, e.Y))
                {
                    if (moveBalls[i].IsBallOnMap())
                    {
                        catchesBallsCount++;
                        catchesBallsCountLabel.Text = catchesBallsCount.ToString();
                        moveBalls[i].Stop();
                        moveBalls[i].Clear();
                        moveBalls.RemoveAt(i);
                        break;
                    }
                }
            }
            if (moveBalls.Count() == 0)
            {
                showCatchesBallsCount();
                ClearMap();
            }
        }        
        public void showCatchesBallsCount()
        {
            MessageBox.Show(catchesBallsCount == ballsCount ? $"Поздравляем, Вы поймали все {catchesBallsCount} шарика(-ов)!" : $"Поздравляем, Вы успели поймать {catchesBallsCount} шарика(-ов)!");
        }
    }
}