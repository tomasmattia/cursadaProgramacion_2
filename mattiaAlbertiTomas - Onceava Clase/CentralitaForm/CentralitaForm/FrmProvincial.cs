using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CentralitaTelefonica;

namespace CentralitaForm
{
    public partial class FrmProvincial : CentralitaForm.FrmLlamada
    {
        private Provincial _llamadaProvincial;

        public Provincial MiLlamadaProvincial
        {
            get { return _llamadaProvincial; }
        }

        public FrmProvincial()
        {
            InitializeComponent();
            foreach (Franja unaFranja in Enum.GetValues(typeof(Franja)))
            {
                this.comboBox1.Items.Add(unaFranja);
            }
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base._llamada = new Llamada(base.txtOrigen.Text, base.txtDestino.Text, float.Parse(base.txtDuracion.Text));
            this._llamadaProvincial = new Provincial(((Franja)this.comboBox1.SelectedItem), base.MiLlamada);
            this.DialogResult = DialogResult.OK;
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.btnCancelar_Click(sender, e);
        }
    }
}
