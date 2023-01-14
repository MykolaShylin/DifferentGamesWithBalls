using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using BallGameWinFormsLibrary;

namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
        public List<MoveBall> moveBalls;
        PointBall pointBall;
        private int ballsCount = 10;
        public int catchesBallsCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
            clearMapButton.Enabled = true;
        }

        private void stopMovingButton_Click(object sender, EventArgs e)
        {
            stopMovingButton.Enabled = false;
            clearMapButton.Enabled = false;
            if (moveBalls != null && moveBalls.Any())
            {
                foreach(var ball in moveBalls)
                {
                    ball.Stop();
                    if(ball.IsBallOnMap())
                    {
                        catchesBallsCount++;
                    }
                }

                MessageBox.Show($"Количество пойманых шариков: {catchesBallsCount}");
                ClearMap();
            }
            else
            {
                MessageBox.Show("На экране нет ниодного шарика! Запустите игру!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void aLotOfBallsButton_Click(object sender, EventArgs e)
        {
            ClearMap();
            stopMovingButton.Enabled = true;
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void clearMapButton_Click(object sender, EventArgs e)
        {
            ClearMap();
            stopMovingButton.Enabled = true;
        }
        public void ClearMap()
        {
            var graphics = CreateGraphics();
            if (moveBalls == null)
            {
                graphics.Clear(Color.White);
                return;
            }
            graphics.Clear(Color.White);
            moveBalls.Clear();
            stopMovingButton.Enabled = false;
            catchesBallsCount = 0;
        }
    }
}