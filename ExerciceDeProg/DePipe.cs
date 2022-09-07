using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public class DePipe : De
    {

        public DePipe():base()
        {
            
        }

        public override int Brasser()
        {
            Random random = new Random();
            int choix1 = random.Next(1, nombreDeFaces + 1);
            int choix2 = random.Next(1, nombreDeFaces + 1);

            if (choix1 > choix2)
            {
                return choix1;
            }
            else
            {
                return choix2;
            }

        }
    }
}
