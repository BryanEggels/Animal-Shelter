using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    public class Asiel
    {

        public string naam
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }
        
        public string Locatie
        {
            get
            {
                return Locatie;
            }
            set
            {
                Locatie = value;
            }
        }
        public string informatie
        {
            get
            {
                return informatie;
            }
            set
            {
                informatie = value;
            }
        }
        public List<Dier> Dieren;
    }
}
