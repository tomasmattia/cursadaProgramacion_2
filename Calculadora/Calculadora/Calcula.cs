using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CalculadoraFRM
{
    public partial class Calculadora : Form
    {
        private int num1;
        private int num2;
        private string operacion="";
        private string operador = "";
        bool flag;
        Operadores calculador;  
        public Calculadora()
        {
            InitializeComponent();
            calculador= new Operadores();
        }

        private void CalculadoraFRM_Load(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ReadOnly = true;
            foreach (Control i in this.panel1.Controls)
            {
                i.Click += new EventHandler(this.ManejadorOperacion);
            }
            flag = false;
            this.clearbtn.Click += new EventHandler(this.ManejadorOperacion);
        }

        public void ManejadorOperacion(object sender, EventArgs ea)
        {
            if (flag == false)
            {
                this.igualbtn.Click += new EventHandler(this.ManejadorOperacion);
                this.sumabtn.Click += new EventHandler(this.ManejadorOperacion);
                this.restabtn.Click += new EventHandler(this.ManejadorOperacion);
                this.multibtn.Click += new EventHandler(this.ManejadorOperacion);
                this.divbtn.Click += new EventHandler(this.ManejadorOperacion);
                flag = true;
            }
            if ((((Button)sender).Text) == "+" || (((Button)sender).Text) == "-" || (((Button)sender).Text) == "/" || (((Button)sender).Text) == "*")
            {
                num1 = int.Parse(this.textBox1.Text);
                operacion += this.textBox1.Text;
                operacion += (((Button)sender).Text);
                operador += (((Button)sender).Text);
                this.textBox1.Clear();
                this.igualbtn.Click -= new EventHandler(this.ManejadorOperacion);
                this.sumabtn.Click -= new EventHandler(this.ManejadorOperacion);
                this.restabtn.Click -= new EventHandler(this.ManejadorOperacion);
                this.multibtn.Click -= new EventHandler(this.ManejadorOperacion);
                this.divbtn.Click -= new EventHandler(this.ManejadorOperacion);
                flag = false;
            }
            else
            {
                if ((((Button)sender).Text) == "=")
                {
                    num2 = int.Parse(this.textBox1.Text);
                    operacion += this.textBox1.Text;
                    operacion += (((Button)sender).Text);
                    OpeDel delegado= new OpeDel(calculador.ElegirOperacion);
                    this.textBox1.Text = delegado.Invoke(operador, num1, num2).ToString();
                    operacion += this.textBox1.Text;
                    calculador.Guardar(operacion);
                    foreach (Control i in this.Controls)
                    {
                        i.Click -= new EventHandler(this.ManejadorOperacion);
                    }
                    foreach (Control i in this.panel1.Controls)
                    {
                        i.Click -= new EventHandler(this.ManejadorOperacion);
                    }
                    this.clearbtn.Click += new EventHandler(this.ManejadorOperacion);
                }
                else
                {
                    if ((((Button)sender).Text) == "C")
                    {
                        operacion = "";
                        operador = "";
                        num1 = 0;
                        num2 = 0;
                        this.textBox1.Clear();
                        foreach (Control i in this.panel1.Controls)
                        {
                            i.Click += new EventHandler(this.ManejadorOperacion);
                        }
                        flag = false;
                    }
                    else
                    {
                        this.textBox1.Text += (((Button)sender).Text);
                    }
                }
            }
        }
    }
}
