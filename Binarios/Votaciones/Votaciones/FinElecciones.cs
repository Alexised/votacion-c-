using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLLCandidatos;

namespace Votaciones
{
    public partial class FinElecciones : Form
    {
        byte x = 0;
        SqlDataReader tabla;
        Class1 Ob = new Class1();
        string NomBD = "BDCandidatos";

        public FinElecciones()
        {
            InitializeComponent();
            x = 0;
        }

        private void FinElecciones_Load(object sender, EventArgs e)
        {

        }
        private void Llamar(string con)
        {
            tabla = Ob.consulta(con, Ob.conectar(NomBD));
        }

        private void btXCandidato_Click(object sender, EventArgs e)
        {
            dgvXCandidato.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Busqueda;

            int Contador = 0, i = 0;
            string Ronda = "";
            double Prom;
            
                dgvXCandidato.Visible = false;
                            
            
                Busqueda = true;
                
                Llamar("SELECT SUM(CantidadVotos) FROM Candidatos");

                while (tabla.Read())
                {
                    Contador = Int32.Parse(tabla[0].ToString());
                }
                Prom = Contador / 2;
                Llamar("SELECT Nombre, CantidadVotos FROM Candidatos");
                while (tabla.Read())
                {
                   
                    if ((Prom + 1) <= Int32.Parse(tabla[1].ToString()))
                    {
                        MessageBox.Show("Ganador " + tabla[0].ToString());
                        Busqueda = false;
                    }
                }
                Llamar("SELECT Nombre, CantidadVotos FROM Candidatos ORDER BY CantidadVotos DESC");
                while (tabla.Read() & Busqueda)
                {
                    if (i == 0)
                    {
                        Ronda += tabla[0].ToString() + tabla[1].ToString();
                    }
                    if (i == 1)
                    {
                        Ronda += tabla[0].ToString() + tabla[1].ToString();
                    }
                    i++;
                }


                dgvXPartido.Visible = true;
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

       
    }
}
