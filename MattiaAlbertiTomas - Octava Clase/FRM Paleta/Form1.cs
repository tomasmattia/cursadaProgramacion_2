using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.listColores.Items.Clear();
            mostrarTemperas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listColores.SelectedIndex;
            FormTempera frmTemp = new FormTempera(this._paleta.getTemperas()[index]);
            if (frmTemp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.listColores.Items.Clear();
                this._paleta.getTemperas().RemoveAt(index);
            }
            this.listColores.Items.Clear();
            mostrarTemperas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void mostrarTemperas()
        {
            foreach (Tempera temp in this._paleta.getTemperas())
            {
                this.listColores.Items.Add(Tempera.Mostrar(temp));
            }
        }
    }
}
