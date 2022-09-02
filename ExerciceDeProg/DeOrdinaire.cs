using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public class DeOrdinaire
    {
        protected const int nombreDeFaces = 6;
        public const string typeDeDe = "Ordinaire";

        public DeOrdinaire()
        {

        }

        public virtual int Brasser()
        {
            Random random = new Random();

            return random.Next(1, nombreDeFaces + 1);
        }
    }
}
