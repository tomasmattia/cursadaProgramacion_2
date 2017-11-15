using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtroTesteo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ManejadorGenerico(object sender, EventArgs ea)
        {
            if (sender is Button)
            {
                if (sender == this.button1)
                {
                    MessageBox.Show("Soy el boton 1");
                    ((Button)sender).Click -= new EventHandler(this.ManejadorGenerico);
                    this.button2.Click += new EventHandler(this.ManejadorGenerico);
                }
                else
                {
                    if (sender == this.button2)
                    {
                        MessageBox.Show("Soy el boton 2");
                        ((Button)sender).Click -= new EventHandler(this.ManejadorGenerico);
                        this.button3.Click += new EventHandler(this.ManejadorGenerico);
                    }
                    else
                    {
                        if (sender == this.button3)
                        {
                            MessageBox.Show("Soy el boton 3");
                            ((Button)sender).Click -= new EventHandler(this.ManejadorGenerico);
                            this.button4.Click += new EventHandler(this.ManejadorGenerico);
                        }
                        else
                        {
                            if (sender == this.button4)
                            {
                                MessageBox.Show("Soy el boton 4");
                                ((Button)sender).Click -= new EventHandler(this.ManejadorGenerico);
                                this.button1.Click += new EventHandler(this.ManejadorGenerico);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.button1.Click+=new EventHandler(this.ManejadorGenerico);
        }
    }
}
