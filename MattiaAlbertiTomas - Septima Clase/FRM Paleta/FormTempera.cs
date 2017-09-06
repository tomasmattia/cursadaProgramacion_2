using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase06;

namespace FRM_Tempera
{
    public partial class FormTempera : Form
    {
        private Tempera _tempera;

        public FormTempera()
        {
            InitializeComponent();
        }

        public Tempera GetTempera()
        {
            this._tempera = new Tempera(ConsoleColor.Red, textBox1.Text, int.Parse(textBox3.Text));
            return this._tempera;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetTempera();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
