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

namespace FRMProveedorPersonas
{
    public partial class FRMabm : Form
    {
        private Persona unaPersona;

        public Persona PersonaDelFrom { get { return unaPersona; } }

        public FRMabm()
        {
            InitializeComponent();
        }

        public FRMabm(Persona unaP):this()
        {
            unaPersona = unaP;
            this.textBox1.Text = unaP.nombre;
            this.textBox2.Text = unaP.apellido;
            this.textBox3.Text = unaP.edad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (unaPersona == null)
            {
                id = 0;
            }
            else
            {
                id = unaPersona.id;
            }
            unaPersona = new Persona(id, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            this.DialogResult = DialogResult.OK;
        }

    }
}
