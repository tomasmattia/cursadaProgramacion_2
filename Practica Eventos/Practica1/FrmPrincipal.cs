using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados frmTest = new FrmTestDelegados();
            frmTest.Owner = this;
            frmTest.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos frmDatos = new FrmDatos();
            frmDatos.Owner = this;
            frmDatos.Show();
        }

        private void mostrarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
