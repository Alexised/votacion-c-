using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DLLCandidatos
{
    public class Class1
    {

        public void CargarElectores()
        {
            FileStream FileStr;
            BinaryWriter BinWriter;
            try
            {
                FileStr = new FileStream("Electores.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinWriter = new BinaryWriter(FileStr);

                BinWriter.Write("123");
                BinWriter.Write("DANIEL");
                BinWriter.Write("NO");
                BinWriter.Write("234");
                BinWriter.Write("ANDRES");
                BinWriter.Write("NO");
                BinWriter.Write("345");
                BinWriter.Write("JORGE");
                BinWriter.Write("NO");
                BinWriter.Write("456");
                BinWriter.Write("GLORIA");
                BinWriter.Write("NO");
                BinWriter.Write("567");
                BinWriter.Write("CARLOS");
                BinWriter.Write("NO");
                BinWriter.Close();
                FileStr.Close();
            }
            catch (Exception ex)
            {
                
            }
        }

        public bool BuscarElectores(string Cedula, string Nombre)
        {
            string Ced;
            FileStream FileStr = new FileStream("Electores.txt", FileMode.Open, FileAccess.Read);
            BinaryReader BinRead = new BinaryReader(FileStr);
            try
            {
            Ced = BinRead.ReadString();

            while (Ced != null)
            {
              if (Cedula == Ced)
               {
              if (Nombre == BinRead.ReadString())
               {
              if ("NO" == BinRead.ReadString())
              {
               return true;
              }
              }
              }
               Ced = BinRead.ReadString();
             }
            }
            catch (Exception ex)
            {

            }
            FileStr.Close();
            BinRead.Close();
            return false;
        }



        public SqlConnection conectar(string nomBD)
        {
            SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial Catalog=" + nomBD + ";Integrated Security=SSPI;");
            try
            {
                conectar.Open();
                MessageBox.Show("Se realizo la conexion...");
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }

        public SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        public int operarar(string conSQL, SqlConnection conector)
        {
            int num = 0;

            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta" + e.ToString());
                return num;
            }
        }

        public void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq)
            {

            }
        }

    }
}
