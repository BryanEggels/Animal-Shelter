using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter.Context
{
    class MemoryContext : IDogContext
    {
        List<DateTime> uitlaatlijst = new List<DateTime>();

        public List<DateTime> Getlist()
        {
            
            for (int i = 1; i < 10; i++)
            {
                DateTime date = new DateTime(10 / i / 10);
                uitlaatlijst.Add(date);
            }

            return uitlaatlijst;
        }

        public bool walkdog(DateTime Walkdate, Hond dog)
        {   
            if (true)
            {
                uitlaatlijst.Add(Walkdate);
                return true;
            }
            else if (false)
            {
                return false;
            }
            
            
        }

    }
}
