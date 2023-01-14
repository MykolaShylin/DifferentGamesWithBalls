using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BallGameWinFormsLibrary
{
    public class MoveBall : RandomSizeAndPointBall
    {        
        public MoveBall(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        protected virtual int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            int sign = 1;
            if (randomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(2, 6) * sign;
        }
    }
}
