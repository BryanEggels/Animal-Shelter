using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter
{
    class UitlaatException : Exception
    {
        public UitlaatException()
        {

        }

        public UitlaatException(string message) : base(message)
        {

        }
    }
}
