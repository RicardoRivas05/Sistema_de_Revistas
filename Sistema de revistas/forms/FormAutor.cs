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
    public partial class FormAutor : Form
    {
        Form formsubirar;
        public FormAutor()
        {
            InitializeComponent();
            formsubirar = new forms.FormSubirArticulo();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsubir_Click(object sender, EventArgs e)
        {
            formsubirar.Show();
        }
    }
}
