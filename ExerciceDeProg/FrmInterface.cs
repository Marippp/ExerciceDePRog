using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDeProg
{
    public partial class FrmInterface : Form
    {
        Controleur controleur = new Controleur();
        public FrmInterface()
        {
            InitializeComponent();
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            controleur.TypeDeDeChoisi();
            controleur.BrasserTypeDeDeChoisi();
        }

        private void FrmInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
