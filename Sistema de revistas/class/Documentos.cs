using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_revistas
{
    /*public class Documentos
    {
        private string Titulo;
        private string PaginaInicio;
        private string PaginaFin;
        private string NombreAutor;
        private byte[] documento;
        private string extension;

        SqlConnection conexion = new SqlConnection("server = DESKTOP-MUK8L7T; database = Revistas; integrated security = true");

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string PaginaInicio1 { get => PaginaInicio; set => PaginaInicio = value; }
        public string PaginaFin1 { get => PaginaFin; set => PaginaFin = value; }
        public string NombreAutor1 { get => NombreAutor; set => NombreAutor = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }
        

        public string AgregarDocmuento()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO Articulos VALUES (@Titulo, @PaginaInicio, @PaginaFin, @NombreAutor, @documento, @extension");
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Titulo", Titulo1);
            comando.Parameters.AddWithValue("@PaginaInicio", PaginaInicio1);
            comando.Parameters.AddWithValue("@PaginaFin", PaginaFin1);
            comando.Parameters.AddWithValue("@NombreAutor", NombreAutor1);
            comando.Parameters.AddWithValue("@documento", Documento);
            comando.Parameters.AddWithValue("@extension", Extension);
            comando.ExecuteNonQuery();
            conexion.Close();
            return "Agregado con éxito";
        }

    }*/
}
