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
        private DateTime tiempoFinal;
        private TimeSpan _diferencia;

        public FrmFinLlamada()
        {
            InitializeComponent();
        }
        
        public FrmFinLlamada(Llamada unaLlamada):this()
        {
            this._llamada = unaLlamada;
            txtDestino.Text = unaLlamada.NroDestino;
            txtDestino.ReadOnly = true;
            txtOrigen.Text = unaLlamada.NroOrigen;
            txtOrigen.ReadOnly = true;
            tiempoFinal = DateTime.Now;
            _diferencia = tiempoFinal - unaLlamada.TiempoLlamada;
            tiempoInicio.Text = _diferencia.Duration().ToString();
            tiempoInicio.ReadOnly = true;
            unaLlamada.Duracion = (float)_diferencia.TotalMinutes;
            costoFinal.Text= unaLlamada.CostoLlamada.ToString();
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
        }


    }
}
