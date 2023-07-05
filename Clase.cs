using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace RaoIEFI3
{
    internal class Clase
    {
        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb");
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataReader Lector;

        public void CargarPais(string nombrePais)
        {
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";

            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "SELECT NOMBRE_PAIS FROM PAISES WHERE NOMBRE_PAIS = ?";
            Comando.Parameters.AddWithValue("@Pais", nombrePais);

            Comando.Connection.Open();
            Lector = Comando.ExecuteReader();

            if (Lector.HasRows)
            {
                MessageBox.Show("Pais ya agregado");
                Comando.Connection.Close();
                return;
            }

            MessageBox.Show("Pais agregado con exito");
            Lector.Close();

            Comando.CommandText = "INSERT INTO PAISES (NOMBRE_PAISES) VALUES (?)";
            Comando.Parameters.AddWithValue("@Pais", nombrePais.Trim());

            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void CargarCombo(ComboBox cmbPais)
        {
            cmbPais.Items.Clear();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "PAISES";
            Comando.Connection.Open();
            Lector = Comando.ExecuteReader();

            while (Lector.Read())
            {
                cmbPais.Items.Add(Lector[1]);
            }

            Comando.Connection.Close();
        }

        public void AgregarSocio(string nombre, string apellido, string pais, int edad, bool sexo, decimal importe, int puntaje)
        {
            try
            {
                Conexion.Open();

                OleDbCommand Insertar = new OleDbCommand();
                Insertar.Connection = Conexion;
                Insertar.CommandType = CommandType.Text;
                Insertar.CommandText = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES ?,?,?,?,?,?,?";
                Insertar.Parameters.AddWithValue("@Nombre", nombre);
                Insertar.Parameters.AddWithValue("@Apellido", apellido);
                Insertar.Parameters.AddWithValue("@Pais", pais);
                Insertar.Parameters.AddWithValue("@Edad", edad);
                Insertar.Parameters.AddWithValue("@Sexo", sexo);
                Insertar.Parameters.AddWithValue("@Importe", importe);
                Insertar.Parameters.AddWithValue("Puntaje", puntaje);

                Insertar.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        
    }
}
