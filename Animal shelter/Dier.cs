using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    class Dier
    {
        protected double Prijs;
        protected string Naam;
        protected Eigenaar Eigenaar;
        protected Asiel Asiel;
        protected bool Gereserveerd;
        protected bool Is_man;

        public Dier(double prijs, string naam, Asiel asiel, bool man)
        {
            Prijs = prijs;
            Naam = naam;
            Asiel = asiel;
            Is_man = man;
        }
        public void Reserveren(Eigenaar reserverende)
        {
            Eigenaar = reserverende;
        }
    }
}
