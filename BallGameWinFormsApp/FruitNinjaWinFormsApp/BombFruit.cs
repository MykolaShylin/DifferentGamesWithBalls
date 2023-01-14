using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitNinjaWinFormsApp
{
    public class BombFruit : FruitNinja
    {
        public BombFruit(Form form) : base(form)
        {
            brush = new(Color.Black);
        }
    }
}
