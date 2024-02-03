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
    }
}
