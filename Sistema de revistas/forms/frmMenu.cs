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
    public partial class frmMenu : Form
    {
        Form revistas;
        Form editores;
        private frmLogin loginForm;

        public frmMenu(frmLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void tsbRevistas_Click(object sender, EventArgs e)
        {
           
            revistas = new frmRevistas(this);
            revistas.Show();
            this.Hide();
        }

        private void tsbEditores_Click(object sender, EventArgs e)
        {
            editores = new frmEditores(this);
            editores.Show();
            this.Hide();
        }
    }
}