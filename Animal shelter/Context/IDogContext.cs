using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter.Context
{
    interface IDogContext
    {
        bool walkdog(DateTime Walkdate, Hond dog);
        List<DateTime> Getlist();
    }
}
