using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsWinFormsApp
{
    public class BlueBird : RedBird
    {
        public BlueBird(Form form) : base(form)
        {
            brush = Brushes.Blue;
        }
        public BlueBird(Form form, float mouseX, float mouseY, List<Pig> pigs) : base(form)
        {
            brush = Brushes.Blue;
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
