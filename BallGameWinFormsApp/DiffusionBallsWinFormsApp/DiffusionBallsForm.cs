using System.Linq;
using System.Windows.Forms;
using BallGameWinFormsLibrary;

namespace DiffusionBallsWinFormsApp
{
    public partial class DiffusionBallsForm : Form
    {
        private int ballsCount = 10;
        private int heatedLeftBalls;
        private int heatedRightBalls;
        private List<RightSideMolecules> rightBalls;
        private List<LeftSideMolecules> leftBalls;
        private List<Ball> diffusionsBalls;
        int leftWallPreasure = 0;
        int rightWallPreasure = 0;
        int topWallPreasure = 0;
        int downWallPreasure = 0;
        public DiffusionBallsForm()
        {
            InitializeComponent();
        }
        private void DiffusionBallsForm_Load(object sender, EventArgs e)
        {
            RelievePreasures();
        }
        private void DiffusionBallsForm_Paint(object sender, PaintEventArgs e)
        {
            ClearGraphics();
            NewGameLoad();
        }

        private void DiffusionBallsForm_MouseDown(object sender, MouseEventArgs e)
        {
            StartOrStopDiffusionProcess();
        }

        private void StartOrStopDiffusionProcess()
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                for (int i = 0; i < ballsCount; i++)
                {
                    rightBalls[i].Stop();
                    leftBalls[i].Stop();
                }
                MessageBox.Show($"Давление на стенки составило: для синих газов - {heatedRightBalls} атм., для красных газов - {heatedLeftBalls} атм.");                
                rightBalls.Clear();
                leftBalls.Clear();
                diffusionsBalls.Clear();
                RelievePreasures();
                DiffusionBallsForm_Paint(this, null);
            }
            else
            {
                StartDiffusion();
            }
        }

        private void RightBall_OnHeated(object? sender, HitEventArgs e)
        {
            heatedRightBalls++;
            switch (e.Side)
            {
                case Side.Left:
                    leftPressureLabel.Text = $"{leftWallPreasure++} атм.";
                    break;
                case Side.Right:
                    rightPressureLabel.Text = $"{rightWallPreasure++} атм.";
                    break;
                case Side.Top:
                    topPressureLabel.Text = $"{topWallPreasure++} атм.";
                    break;
                case Side.Dowm:
                    downPressureLabel.Text = $"{downWallPreasure++} атм.";
                    break;
            }
        }

        private void LeftBall_OnHeated(object? sender, HitEventArgs e)
        {
            heatedLeftBalls++;
            switch (e.Side)
            {
                case Side.Left:
                    leftPressureLabel.Text = $"{leftWallPreasure++} атм.";
                    break;
                case Side.Right:
                    rightPressureLabel.Text = $"{rightWallPreasure++} атм.";
                    break;
                case Side.Top:
                    topPressureLabel.Text = $"{topWallPreasure++} атм.";
                    break;
                case Side.Dowm:
                    downPressureLabel.Text = $"{downWallPreasure++} атм.";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiffusionProcessIsOnTheWork();
        }

        private void DiffusionProcessIsOnTheWork()
        {
            for (int i = 0; i < ballsCount; i++)
            {
                if (leftBalls[i].IsOnTheRightSide() && !diffusionsBalls.Any(ball => ball == leftBalls[i]))
                {
                    diffusionsBalls.Add(leftBalls[i]);
                }
                else if (!leftBalls[i].IsOnTheRightSide() && diffusionsBalls.Any(ball => ball == leftBalls[i]))
                {
                    diffusionsBalls.Remove(leftBalls[i]);
                }
                if (rightBalls[i].IsOnTheLeftSide() && !diffusionsBalls.Any(ball => ball == rightBalls[i]))
                {
                    diffusionsBalls.Add(rightBalls[i]);
                }
                else if (!rightBalls[i].IsOnTheLeftSide() && diffusionsBalls.Any(ball => ball == rightBalls[i]))
                {
                    diffusionsBalls.Remove(rightBalls[i]);
                }
                if (diffusionsBalls.Count() == ballsCount)
                {
                    if (diffusionsBalls.Count(ball => ball.GetType() == typeof(LeftSideMolecules)) == diffusionsBalls.Count(ball => ball.GetType() == typeof(RightSideMolecules)))
                    {
                        EndOfDiffusionProcess();
                        break;
                    }
                }
            }
        }

        private void EndOfDiffusionProcess()
        {
            timer1.Enabled = false;
            for (int j = 0; j < ballsCount; j++)
            {
                rightBalls[j].Stop();
                leftBalls[j].Stop();
            }
            MessageBox.Show($"Процесс диффузии завершен!" +
                $" Для завершения понадобилось {heatedRightBalls} ударов синих газов и {heatedLeftBalls} ударов красных газов." +
                $" Общее давление составило {heatedRightBalls + heatedLeftBalls} атм.");
            rightBalls.Clear();
            leftBalls.Clear();
            diffusionsBalls.Clear();
            RelievePreasures();
            DiffusionBallsForm_Paint(this, null);
        }

        private void StartDiffusion()
        {
            diffusionsBalls = new List<Ball>(ballsCount);
            timer1.Enabled = true;
            heatedLeftBalls = 0;
            heatedRightBalls = 0;
            for (int i = 0; i < ballsCount; i++)
            {
                leftBalls[i].OnHeated += LeftBall_OnHeated;
                rightBalls[i].OnHeated += RightBall_OnHeated;
                leftBalls[i].Start();
                rightBalls[i].Start();
            }
        }

        private void NewGameLoad()
        {
            rightBalls = new List<RightSideMolecules>();
            leftBalls = new List<LeftSideMolecules>();
            for (int i = 0; i < ballsCount; i++)
            {
                var leftBall = new LeftSideMolecules(this);
                var rightBall = new RightSideMolecules(this);
                rightBalls.Add(rightBall);
                leftBalls.Add(leftBall);
                leftBall.Show();
                rightBall.Show();
            }
        }

        private void RelievePreasures()
        {
            leftWallPreasure = 0;
            rightWallPreasure = 0;
            topWallPreasure = 0;
            downWallPreasure = 0;
            leftPressureLabel.Text = $"{leftWallPreasure} атм.";
            rightPressureLabel.Text = $"{rightWallPreasure} атм.";
            topPressureLabel.Text = $"{topWallPreasure} атм.";
            downPressureLabel.Text = $"{downWallPreasure} атм.";
        }
        private void ClearGraphics()
        {
            var graphics = CreateGraphics();
            graphics.Clear(Color.White);
        }
        
    }
}