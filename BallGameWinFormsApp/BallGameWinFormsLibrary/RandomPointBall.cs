namespace BallGameWinFormsLibrary
{
    public class RandomPointBall: Ball
    {        
        public RandomPointBall(Form form) : base(form)
        {            
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());            
        }
    }
}
