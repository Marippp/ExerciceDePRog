using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    internal class Controleur
    {
        public string typeDeDeChoisi = "";
        Dictionary<int, string> dictionnaireType = new Dictionary<int, string>();
        DeOrdinaire deOrdinaire = new DeOrdinaire("Ordinaire");
        DePipe dePipe = new DePipe("Pipé");

        public Controleur()
        {
            
        }

        public string TypeDeDeChoisi()
        {
            Random random = new Random();
            int choixDeType = random.Next(1, 3);
            if (choixDeType == 1)
            {
                return deOrdinaire.typeDeDe;
            }
            else
            {
                return dePipe.typeDeDe;
            }
        }

        public void BrasserTypeDeDeChoisi()
        {
            if (TypeDeDeChoisi() == "Ordinaire")
            {
                deOrdinaire.Brasser();
            }
            else
            {
                dePipe.Brasser();
            }
        }
    }
}
