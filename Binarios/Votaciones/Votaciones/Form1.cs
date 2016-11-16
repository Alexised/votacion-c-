using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DLLCandidatos;


namespace Votaciones
{
    public partial class Form1 : Form
    {

        Class1 ObjDLL = new Class1();
        bool Buscar;
        public Form1()
        {
            InitializeComponent();
            ObjDLL.CargarElectores();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            string Cedula;
            string Nombre;

            try
            {

                Cedula = txCedula.Text;
                Nombre = txNombre.Text.ToUpper();

                if (Cedula != "" & Nombre != "")
                {
                    Buscar = ObjDLL.BuscarElectores(Cedula, Nombre);
                    if (Buscar)
                    {
                       
                       Maestro M = new Maestro();
                       M.Show();
                       this.Hide();
                    }
                    else
                    {
                        lbMensaje.Text = "Datos incorrectos ";
                        txCedula.Clear();
                        txNombre.Clear();
                        txNombre.Focus();
                    }

                }
                else
                {
                    lbMensaje.Text = "Llene todos los campos";
                    if (Nombre == "")
                    {
                        txNombre.Focus();
                    }
                    else if (Cedula == "")
                    {
                        txCedula.Focus();
                    }
                }


            }
            catch (Exception)
            {
            }

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
