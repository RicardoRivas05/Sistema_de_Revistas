using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_revistas
{
    public partial class frmLogin : Form
    {
        Form menu;
        Form crearUser;
        public frmLogin()
        {
            InitializeComponent();
            menu = new forms.frmMenu(this);
            crearUser = new forms.CrearCuenta(this);
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            crearUser.Show();
        }
    }
}
