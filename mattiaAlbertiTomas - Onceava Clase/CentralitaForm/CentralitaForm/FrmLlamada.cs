using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaTelefonica;

namespace CentralitaForm
{
    public partial class FrmLlamada : Form
    {
        protected Llamada _llamada;

        public Llamada MiLlamada
        {
            get { return _llamada; }
        }

        protected FrmLlamada()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
