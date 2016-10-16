using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_shelter.Context;

namespace Animal_shelter.Repo 
{
    class DogRepo
    {
        private IDogContext context;


        public DogRepo(IDogContext context)
        {
            this.context = context;
        }
        public bool Getlist(Hond dog)
        {
            dog.Uitlaatlijst = context.Getlist();
            return true;
        }

        public bool walkdog(DateTime Walkdate, Hond dog)
        {
            if (Walkdate != DateTime.Now.Date)
            {
                throw new UitlaatException("dat een andere dag");
            }
            return context.walkdog(Walkdate, dog);
        }
    }
}
