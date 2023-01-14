using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitNinjaWinFormsApp
{
    public class BananaFruit : FruitNinja
    {
        public BananaFruit(Form form) : base(form)
        {
            show = new(Color.Yellow);
        }
    }
}
