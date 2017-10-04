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
    public partial class FrmCentralita : Form
    {
        private Centralita _centralita = new Centralita("La central");
        private TimeSpan _diferencia;

        public Centralita MiCentralita
        {
            get { return _centralita; }
        }

        public FrmCentralita()
        {
            InitializeComponent();
            this.cmbOrden.SelectedIndex = 0;
            this.cmbOrden.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void llamadaLocal_Click(object sender, EventArgs e)
        {
            FrmLlamadaLocal frmLocal = new FrmLlamadaLocal();
            frmLocal.ShowDialog();
            if(frmLocal.DialogResult==DialogResult.OK)
            {
                _centralita += frmLocal.MiLlamada;
                this.listaLlamadas.Items.Clear();
                if (this.cmbOrden.SelectedIndex == 1)
                {
                    OrdenLlamadas();
                }
                foreach (Llamada unaLlamada in _centralita.Llamadas)
                {
                    this.listaLlamadas.Items.Add(unaLlamada);
                }
            }
        }

        private void llamadaProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial frmProvincial = new FrmProvincial();
            frmProvincial.ShowDialog();
            if (frmProvincial.DialogResult == DialogResult.OK)
            {
                _centralita += frmProvincial.MiLlamada;
                this.listaLlamadas.Items.Clear();
                if(this.cmbOrden.SelectedIndex==1)
                {
                    OrdenLlamadas();
                }
                foreach (Llamada unaLlamada in _centralita.Llamadas)
                {
                    this.listaLlamadas.Items.Add(unaLlamada.ToString());
                }
            }
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cmbOrden.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.listaLlamadas.Items.Clear();
                    OrdenLlamadas();
                    foreach (Llamada unaLlamada in _centralita.Llamadas)
                    {
                        this.listaLlamadas.Items.Add(unaLlamada.ToString());
                    }
                    break;
            }
        }

        private void OrdenLlamadas()
        {
            switch(this.cmbOrden.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.MiCentralita.OrdenarLlamadas();
                    break;
            }
        }

        private void terminarLlamada_Click(object sender, EventArgs e)
        {
            int index = listaLlamadas.SelectedIndex;
           
        }
    }
}
