using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    public class Hond : Dier
    {
        

        public List<DateTime> Uitlaatlijst { get; set; }
        public Hond(double prijs, string naam, Asiel asiel, bool man) : base(prijs, naam, asiel, man)
        {
            Uitlaatlijst = new List<DateTime>();
        }
        public void walkdog(DateTime now)
        {
            Uitlaatlijst.Add(now);
        }
    }
}
