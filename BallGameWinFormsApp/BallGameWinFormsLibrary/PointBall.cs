﻿namespace BallGameWinFormsLibrary
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form)
        { 
            this.centerX = x;
            this.centerY = y; 
        }
    }
}
