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
    public partial class FrmFinLlamada : FrmLlamada
    {

        public FrmFinLlamada()
        {

            InitializeComponent();
        }

        public override Llamada MiLlamada
        {
            get { return this._llamada; }
        }


        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.btnCancelar_Click(sender, e);
        }


    }
}
