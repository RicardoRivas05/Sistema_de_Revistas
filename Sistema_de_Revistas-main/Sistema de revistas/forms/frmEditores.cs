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
    public partial class frmEditores : Form
    {
        Form menu;
        public frmEditores(Form menuForm)
        {
            InitializeComponent();
            menu = menuForm;

        }

        private void frmEditores_Load(object sender, EventArgs e)
        {

        }

        private void txtsubir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los Archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
