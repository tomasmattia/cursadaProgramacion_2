using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtroTest
{
    public delegate void DelForm(object x, EventArgs ev);

    public partial class Form1 : Form
    {
        public event DelForm DelegadoForm;

        public Form1()
        {
            InitializeComponent();
        }

        static void ManejadorGenerico(Object o, EventArgs ea)
        {

            if (o is TextBox)
            {
                ((TextBox)o).Font = new Font("Tahoma",18);
                ((TextBox)o).ForeColor = Color.Red;
            }
            else
            {
                if (o is Label)
                {
                    ((Label)o).FlatStyle = FlatStyle.Flat;
                    ((Label)o).ForeColor = Color.Red;
                }
                else
                {
                    ((Button)o).Location= new Point(0,0);
                }
            }
            //MessageBox.Show("Este es el manejador generico"+o.GetType());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                i.Click += new EventHandler(ManejadorGenerico);
            }
        }
    }
}
