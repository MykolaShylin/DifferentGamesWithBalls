using BallGameWinFormsLibrary;

namespace ClosedBallsWinFormsApp
{
    public partial class ClosedBallsForm : Form
    {
        private int ballsCount = 10;
        public ClosedBallsForm()
        {
            InitializeComponent();
        }
        private void aLotOfBallsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ballsCount; i++)
            {
                var ball = new BillyardBall(this);
                ball.OnHeated += Ball_OnHeated;
                ball.Start();
            }
        }

        private void Ball_OnHeated(object? sender, HitEventArgs e)
        {
            switch(e.Side)
            {
                case Side.Left:
                    leftCountBallsLabel.Text = (Convert.ToInt32(leftCountBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightCountBallsLabel.Text = (Convert.ToInt32(rightCountBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topCountBallsLabel.Text = (Convert.ToInt32(topCountBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Dowm:
                    downCountBallsLabel.Text = (Convert.ToInt32(downCountBallsLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}