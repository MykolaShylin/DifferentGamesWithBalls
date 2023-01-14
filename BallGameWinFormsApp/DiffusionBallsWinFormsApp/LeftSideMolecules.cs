using BallGameWinFormsLibrary;

namespace DiffusionBallsWinFormsApp
{
    public class LeftSideMolecules : BillyardBall
    {
        public LeftSideMolecules(Form form) : base(form)
        {
            radius = 15;
            centerX = random.Next(LeftSide(), form.ClientSize.Width / 2 - radius);
            centerY = random.Next(TopSide(), DownSide());
            show = new(Color.Red);
        }

        public bool IsOnTheRightSide()
        {
            return centerX + radius >= form.ClientSize.Width / 2;
        }
    }
}