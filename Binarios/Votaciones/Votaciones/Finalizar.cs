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
    public partial class Finalizar : Form
    {
        public Finalizar()
        {
            InitializeComponent();
        }

        private void btSi_Click(object sender, EventArgs e)
        {
            FinElecciones FE = new FinElecciones();           
            FE.Show();
            this.Hide();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            Maestro M = new Maestro();
            M.Show();
            this.Hide();
        }
    }
}
