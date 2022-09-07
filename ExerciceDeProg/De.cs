using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public abstract class De
    {
        protected const int nombreDeFaces = 6;
        private string typeDeDe;

        public string TypeDeDe { get => typeDeDe;  }

        public De()
        {
            
        }


        public virtual int Brasser()
        {
            Random random = new Random();

            return random.Next(1, nombreDeFaces + 1);
        }
    }
}
