using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallGameWinFormsLibrary;
using SaluteWinFormsApp;

namespace AutoBlowUpSaluteWinFormApp
{
    public class LaunchingStarterSaluteBall : RandomPointBall
    {
        float g = -0.5f;
        float timeForBlowUpPrepearing;
        public LaunchingStarterSaluteBall(Form form) : base(form)
        {
            radius = 15;
            centerY = form.ClientSize.Height + radius * 2;
            vy = -4;
            vx = 0;
            show = new(Color.Gold);
            timeForBlowUpPrepearing = random.Next(radius, form.ClientSize.Height / 2);
        }        
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        public bool IsTimeToBlowUp()
        {            
            return centerY <= form.ClientSize.Height / 2;
        }
        public bool BlowUp()
        {
            return centerY <= TopSide() + timeForBlowUpPrepearing;
        }
        public float GetX()
        {
            return centerX;
        }
        public float GetY()
        {
            return centerY;
        }
    }
}
