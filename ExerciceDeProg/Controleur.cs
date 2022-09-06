using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    internal class Controleur
    {
        private string typeDeDeChoisi = "";
        Dictionary<int, string> dictionnaireType = new Dictionary<int, string>();
        public Controleur()
        {
            dictionnaireType.Add(1, "Ordinaire");
            dictionnaireType.Add(2, "Pipé");

        }
        public string ChoixTypeAuHasard(string typeDeDeChoisi)
        {
            if (typeDeDeChoisi == dictionnaireType[0])
            {
                return "Ordinaire";
            }

            return "Pipé";
        }
        
    }
}
