using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralitaWindowsForms
{
    public partial class LlamadaProvincial : Llamada
    {
        public LlamadaProvincial()
        {
            InitializeComponent();
            franjaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            franjaCombo.SelectedIndex = 0;
        }

        private void LlamadaProvincial_Load(object sender, EventArgs e)
        {

        }

        private void franjaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
