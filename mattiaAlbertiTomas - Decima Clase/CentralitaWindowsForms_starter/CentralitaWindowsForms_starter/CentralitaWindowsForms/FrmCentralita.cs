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
    public partial class FrmCentralita : Form
    {
        public FrmCentralita()
        {
            InitializeComponent();
        }

        private void llamadaLocal_Click(object sender, EventArgs e)
        {
            LlamadaLocal local = new LlamadaLocal();
            local.ShowDialog();
            if (local.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
