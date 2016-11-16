using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLCandidatos;
using System.Data.SqlClient;

namespace Votaciones
{
    public partial class Votar : Form
    {    
        

        public Votar()
        {
            InitializeComponent();
        }

        private void Votar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDCandidatosDataSet.Candidatos' Puede moverla o quitarla según sea necesario.
            this.candidatosTableAdapter.Fill(this.bDCandidatosDataSet.Candidatos);

        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            String nomBD = "BDCandidatos";
            Form1 F = new Form1();
            Votar V = new Votar();
            Class1 objcon = new Class1();
            SqlConnection a;            
            a = objcon.conectar(nomBD);
            int Cod = Int32.Parse(txNumero.Text.Trim());
            string con = "UPDATE Candidatos SET CantidadVotos += 1 WHERE NumeroTargeton =" + Cod + ";";
            int n = objcon.operarar(con, a);
                if (n > 0)
                {
                    
                    MessageBox.Show("Se realizo la votacion");
                this.Close();
                    F.Show();
                    
                }
                else
                {
                    MessageBox.Show("Error en la votacion");
                    V.Show();
                }

                
            }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Maestro M = new Maestro();
            M.Show();
            this.Hide();
        }
            
        }
    }


