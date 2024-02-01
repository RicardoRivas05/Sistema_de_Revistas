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
    public partial class frmRevistas : Form
    {
       
        Form menu;
        public frmRevistas(Form menuForm)
        {
            InitializeComponent();
            menu = menuForm;
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void frmRevistas_Load(object sender, EventArgs e)
        {

        }
    }
}
