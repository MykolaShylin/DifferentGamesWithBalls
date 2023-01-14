namespace BallGameWinFormsLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall
    {        
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(25, 60);
        }
    }
}
