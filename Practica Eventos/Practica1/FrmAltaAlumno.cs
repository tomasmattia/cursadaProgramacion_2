using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FrmAltaAlumno : Form
    {
        private string path;
        private Entidades.Alumno alumnito;

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialog1.InitialDirectory = path;
            this.openFileDialog1.Title = "Seleccione una foto";
            this.openFileDialog1.Filter = "Fotografias|*.jpg";
            this.openFileDialog1.Multiselect = false;
        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            alumnito = new Entidades.Alumno(this.textBox1.Text, this.textBox2.Text, int.Parse(this.textBox3.Text), this.textBox4.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = this.openFileDialog1.FileName;
        }
    }
}
