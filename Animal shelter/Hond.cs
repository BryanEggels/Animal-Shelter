using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    class Hond : Dier
    {
        List<DateTime> uitlaatlijst;
        public Hond(double prijs, string naam, Asiel asiel, bool man) : base(prijs, naam, asiel, man)
        {

        }
    }
}
