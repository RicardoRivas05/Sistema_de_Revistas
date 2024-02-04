using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_revistas.forms
{
    public partial class CrearCuenta : Form
    {
        Conexion conexion = new Conexion();

        private frmLogin loginForm;
        public CrearCuenta(frmLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            radioButton2.Select();
            lblAdscripcion.Visible = false;
            txtAdscripcion.Visible = false;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblAdscripcion.Visible = false;
            txtAdscripcion.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblAdscripcion.Visible = true;
            txtAdscripcion.Visible = true;

        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumTel.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtAdscripcion.Clear();
            radioButton2.Select();
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string numero = txtNumTel.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string password = txtContra.Text;
            DateTime fecha = DateTime.Now;
            string adscripcion = txtAdscripcion.Text;
            int tipoUser = Convert.ToInt32(radioButton1.Tag);
            tipoUser += 1;

            if (conexion.InsertarDatos(nombre, apellido, numero, correo, usuario, password, fecha, adscripcion, tipoUser))
            {
                MessageBox.Show("El usuario fue registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al insertar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
