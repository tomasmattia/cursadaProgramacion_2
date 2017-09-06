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
using FRM_Tempera;

namespace FRM_Paleta
{
    public partial class Form1 : Form
    {
        private Paleta _paleta;
        public Form1()
        {
            InitializeComponent();
            _paleta = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTempera frmTemp = new FormTempera();
            frmTemp.ShowDialog();
            if (frmTemp.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._paleta += frmTemp.GetTempera();
                this.listColores.Items.Clear();
                this.listColores.Items.Add((string)this._paleta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTempera frmTemp = new FormTempera();
            frmTemp.ShowDialog();
            if (frmTemp.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._paleta -= frmTemp.GetTempera();
                this.listColores.Items.Clear();
                this.listColores.Items.Add((string)this._paleta);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
