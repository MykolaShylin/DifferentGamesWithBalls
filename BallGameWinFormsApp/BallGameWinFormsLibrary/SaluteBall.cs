using BallGameWinFormsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluteWinFormsApp
{    
    public class SaluteBall : MoveBall
    {
        private float g = 0.3f;        
        public SaluteBall(Form form, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            radius = 5;
            show = new(Color.FromArgb(255,(byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
            
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }

        protected override int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            int sign = 1;
            if (randomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(0, 20) * sign;
        }
    }
}
