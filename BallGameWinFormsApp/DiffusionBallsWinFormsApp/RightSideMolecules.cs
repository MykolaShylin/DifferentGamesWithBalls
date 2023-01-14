using BallGameWinFormsLibrary;

namespace DiffusionBallsWinFormsApp
{
    public class RightSideMolecules : BillyardBall
    {        
        public RightSideMolecules(Form form) : base(form)
        {
            radius = 15;
            centerX = random.Next(form.ClientSize.Width / 2 + radius, RightSide());
            centerY = random.Next(TopSide(), DownSide());
            show = new(Color.Blue);
        }
        public bool IsOnTheLeftSide()
        {
            return centerX - radius >= form.ClientSize.Width / 2;
        }

    }
}