using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votaciones
{
    public partial class Maestro : Form
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void votarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Votar V = new Votar();                       
            V.Show();
            this.Hide();
        }

        private void finEleccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finalizar F = new Finalizar();            
            F.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maestro_Load(object sender, EventArgs e)
        {

        }
    }
}
