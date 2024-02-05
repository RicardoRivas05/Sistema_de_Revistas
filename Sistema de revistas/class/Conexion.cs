using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_de_revistas
{

    class Conexion
    {
        private SqlConnection SqlConnection;
        private string connectionString;

        public Conexion()
        {
            this.connectionString = "server = DESKTOP-MUK8L7T; database = Revistas; integrated security = true";
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

        public bool InsertarDatos(string nombre, string apellido, string numero, string correo, string usuario, string password, DateTime fecha, string adscripcion, int tipoUser)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Usuarios (Nombre, Apellido, NumeroTelefonico, Correo, Usuario, Contraseña, FechaRegistro, Adscripcion, IdTipoUsuario) VALUES " +
                                   "(@nombre, @apellido, @numero, @correo, @usuario, @password, @fecha, @adscripcion, @tipoUser)";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@numero", numero);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@adscripcion", adscripcion);
                        command.Parameters.AddWithValue("@tipoUser", tipoUser);

                        int filasAfectadas = command.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar datos en la base de datos: " + ex.Message);
                return false;  // Retorna false en caso de error
            }
        }


        /*public bool InsertarDatosEd(string nombreEd, string apellidoEd, string numeroEd, string correoEd, string usuarioEd, string passwordEd, DateTime fechaEd, string cargoEd)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Editores (Nombre, Apellido, NumeroTelefonico, Correo, Usuario, Contraseña, FechaRegistro, Adscripcion, IdTipoUsuario) VALUES " +
                                   "(@nombre, @apellido, @numero, @correo, @usuario, @password, @fecha, @adscripcion, @tipoUser)";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@numero", numero);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@adscripcion", adscripcion);
                        command.Parameters.AddWithValue("@tipoUser", tipoUser);

                        int filasAfectadas = command.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar datos en la base de datos: " + ex.Message);
                return false;  // Retorna false en caso de error
            }
        }*/

    }

}
