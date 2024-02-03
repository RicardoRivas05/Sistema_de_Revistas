using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_de_revistas
{

    class Conexion
    {
        private SqlConnection SqlConnection;
        private string connectionString;

        public Conexion()
        {
            this.connectionString = "server = RICARDOPC; database = Revistas; integrated security = true";
            this.SqlConnection = new SqlConnection(this.connectionString);
        }

        public void Open()
        {
            try
            {
                SqlConnection.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion, ", ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                SqlConnection.Close();
                Console.WriteLine("Conexion cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexion");
            }
        }

        public bool ValidarCredenciales(string user, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @user AND Contraseña = @password";
                using (SqlCommand command = new SqlCommand(query, SqlConnection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar credenciales: " + ex.Message);
                return false;
            }
        }


    }

}
