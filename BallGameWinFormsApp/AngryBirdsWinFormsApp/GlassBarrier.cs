using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsWinFormsApp
{
    public class WaterBarrier : MetallBarrier
    {
        public WaterBarrier(Form form) : base(form)
        {
            show = new(Color.FromArgb(186, 219, 255));
        }
    }
}
