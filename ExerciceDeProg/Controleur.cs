using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public class Controleur
    {
        public string typeDeDeChoisi = "";
        DeOrdinaire deOrdinaire = new DeOrdinaire();
        DePipe dePipe = new DePipe();
        private int totalDesPoints;
        public Controleur(int totalDesPoints)
        {
            this.totalDesPoints = totalDesPoints;
        }

        public string TypeDeDeChoisi()
        {
            Random random = new Random();
            int choixDeType = random.Next(1, 3);
            if (choixDeType == 1)
            {
                return deOrdinaire.TypeDeDe = "Ordinaire";
            }
            else
            {
                return dePipe.TypeDeDe = "Pipé";
            }
        }

        public int BrasserTypeDeDeChoisi()
        {

            if (TypeDeDeChoisi() == "Ordinaire")
            {
                return deOrdinaire.Brasser();
            }
            else
            {
                return dePipe.Brasser();
            }
        }

        public int CalculerTotalDesPoints()
        {
            return totalDesPoints += BrasserTypeDeDeChoisi();
        }
    }
}
