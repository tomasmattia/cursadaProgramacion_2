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

namespace TesteoForm
{
    public partial class Form1 : Form
    {
        Empleado e1;
        public Form1()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            e1 = new Empleado();
            e1.limiteSueldo += new DelEmp(ManejadorEvento);
            e1.EmpleadoBoton += new ElBoton(new Form1().ManejadorBoton);
            e1.EmpleadoReBoton += new ElReBoton(new Form1().ManejadorReBoton);
            e1.DelegadoForm += new DelForm(new Form1().ManejadorDelForm);
            e1.Nombre = this.textBox1.Text;
            e1.Apellido = this.textBox2.Text;
            e1.Sueldo = double.Parse(this.textBox3.Text);
        }

        static void ManejadorEvento()
        {
            MessageBox.Show("Handling limite sueldo");
        }

        public void ManejadorEvento2()
        {
            MessageBox.Show("Handling 2 limite sueldo");
        }

        public void ManejadorBoton(Empleado e)
        {
            MessageBox.Show("Este se esta subiendo el sueldo " + e.Nombre + " " + e.Apellido);
        }

        public void ManejadorReBoton(Empleado e, double crimen)
        {
            MessageBox.Show("Este se esta subiendo el sueldo " + e.Nombre + " " + e.Apellido + " a " + crimen.ToString());
        }

        public void ManejadorDelForm(object e, EmpleadoEventArgs ev)
        {
            MessageBox.Show("DEL FORM: Este se esta subiendo el sueldo " + ((Empleado)e).Nombre + " " + ((Empleado)e).Apellido + " a " + ev.sueldo.ToString());
            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
