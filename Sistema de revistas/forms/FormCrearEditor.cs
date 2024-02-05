using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sistema_de_revistas.forms
{
    public partial class FormCrearEditor : Form
    {
        Conexion conexion = new Conexion();
        public FormCrearEditor()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNombreEd.Clear();
            txtApellidoEd.Clear();
            txtNumTelEd.Clear();
            txtCorreoEd.Clear();
            txtUsuarioEd.Clear();
            txtContraEd.Clear();
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            string nombreEd = txtNombreEd.Text;
            string apellidoEd = txtApellidoEd.Text;
            string numeroEd = txtNumTelEd.Text;
            string correoEd = txtCorreoEd.Text;
            string usuarioEd = txtUsuarioEd.Text;
            string passwordEd = txtContraEd.Text;
            string cargoEd = txtcargoEd.Text;
            DateTime fechaEd = DateTime.Now;


            /*if (conexion.InsertarDatos(nombreEd, apellidoEd, numeroEd, correoEd, usuarioEd, passwordEd, fechaEd,cargoEd))
            {
                MessageBox.Show("El Editor fue registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al insertar el Editor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
    }
}
