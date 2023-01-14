using BallGameWinFormsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsWinFormsApp
{
    public class Pig : RandomPointBall
    {
        
        public Pig(Form form) : base(form)
        {
            radius = 20;
            vx = 0;
            vy = 0;
        }
        public override void Show()
        {
            HideOrShow(Brushes.Green);
        }
        
        public float GetX()
        {
            return centerX;
        }
        public float GetY()
        {
            return centerY;
        }
        public int GetRadius()
        {
            return radius;
        }
    }
}
