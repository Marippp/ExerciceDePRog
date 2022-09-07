using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public class DeOrdinaire : De
    {
        public DeOrdinaire(): base()
        {
            
        }

        public override int Brasser()
        {
            Random random = new Random();

            return random.Next(1, nombreDeFaces + 1);
        }
    }
}
