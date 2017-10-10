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

        public override Llamada MiLlamada
        {
            get
            {
                return _llamadaProvincial;
            }
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
            this._llamadaProvincial = new Provincial(base.txtOrigen.Text, ((Franja)this.comboBox1.SelectedItem), DateTime.Now, base.txtDestino.Text);
            this.DialogResult = DialogResult.OK;
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
