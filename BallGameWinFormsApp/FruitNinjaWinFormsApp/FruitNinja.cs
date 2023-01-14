using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallGameWinFormsLibrary;

namespace FruitNinjaWinFormsApp
{
    public class FruitNinja : MoveBall
    {
        protected SolidBrush brush;
        public float g = 0.2f;
        public FruitNinja(Form form) : base(form)
        {
            centerY = form.ClientSize.Height;
            vy = random.Next(-20, -14);
            show = new(Color.FromArgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(1, 256)));
            
        } 
        protected override void Go()
        {
            base.Go();
            ChangeBallDirection();
            vy += g;
        }
        public override bool IsBallOnMap()
        {
            return centerY >= TopSide() && centerY <= DownSide();
        }
        protected virtual void ChangeBallDirection()
        {
            if (centerX >= RightSide())
            {
                vx = -vx;
            }
            if (centerX <= LeftSide())
            {
                vx = -vx;
            }
        }
    }
}
