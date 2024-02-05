using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_revistas.forms
{
    public partial class FormSubirArticulo : Form
    {
        //Documentos objDoc = new Documentos();
        public FormSubirArticulo()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            /*openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Documento de Microsoft Word (*.docx)|*.docx";
            openFileDialog1.FilterIndex = 2;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = openFileDialog1.FileName;
            }*/
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            /*byte[] archivo = null;
            Stream Mystream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            Mystream.CopyTo(obj);
            archivo = obj.ToArray();

            //subir
            objDoc.Titulo1 = txttitulo.Text;
            objDoc.PaginaInicio1 = txtpaginicio.Text;
            objDoc.PaginaFin1 = txtpagfin.Text;
            objDoc.NombreAutor1 = txtautor.Text;
            objDoc.Documento = archivo;
            objDoc.Extension = openFileDialog1.SafeFileName;
            MessageBox.Show(objDoc.AgregarDocmuento());*/

        }
    }
}
