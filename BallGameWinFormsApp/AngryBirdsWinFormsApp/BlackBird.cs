using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallGameWinFormsLibrary;

namespace AngryBirdsWinFormsApp
{
    public class BlackBird : RedBird
    {
        public BlackBird(Form form) : base(form)
        {
            brush = Brushes.Black;
        }
        public BlackBird(Form form, float mouseX, float mouseY, List<Pig> pigs) : base(form)
        {
            brush = Brushes.Black;
            speed = timer.Interval;
            this.mouseX = mouseX;
            this.mouseY = mouseY;
            radius = birdRadius;
            centerX = radius;
            centerY = DownSide();
            vx = mouseX / speed * g;
            vy = -((centerY - mouseY) / speed) * g;
            birdJumpHeight = vy;
            this.pigs = pigs;
        }   
        
    }
}
