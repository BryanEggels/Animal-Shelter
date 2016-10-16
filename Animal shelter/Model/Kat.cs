using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    public class Kat : Dier
    {
        private string informatie;
        public Kat(double prijs, string naam, Asiel asiel, bool man, string info) : base(prijs, naam, asiel, man)
        {
            informatie = info;
        }
        public override string ToString()
        {
            return base.ToString() + " " + informatie;
        }
    }
}
