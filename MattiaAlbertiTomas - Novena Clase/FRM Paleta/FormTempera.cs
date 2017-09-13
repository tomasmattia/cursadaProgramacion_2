using FRM_Paleta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRM_Tempera
{
    public partial class FormTempera : Form
    {

        private Tempera _tempera;

        public Tempera Tempera
        {
            get { return this._tempera; }
        }

        public FormTempera()
        {
            InitializeComponent();
            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(color);
            }
            this.comboBox1.SelectedItem = ConsoleColor.Black;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FormTempera(Tempera unaTempera):this()
        {
            this.textBox1.Text = unaTempera.Marca;
            this.comboBox1.SelectedItem = unaTempera.Color;
            this.textBox3.Text = ((int)unaTempera).ToString();
            this.textBox1.ReadOnly = true;
            this.comboBox1.Enabled = false;
            this.textBox3.ReadOnly = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._tempera = new Tempera((ConsoleColor)comboBox1.SelectedItem, textBox1.Text, int.Parse(textBox3.Text));
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
