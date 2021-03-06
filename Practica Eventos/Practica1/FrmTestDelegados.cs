﻿using System;
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
    public partial class FrmTestDelegados : Form
    {
        private string path;

        public FrmTestDelegados()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            ((FrmPrincipal)this.Owner).actualizarNombrePorDelegado(this.nombreBox.Text);
            ((FrmPrincipal)this.Owner).actualizarFotoPorDelegado(path);
        }

        private bool ConfigurarOpenSaveFileDialog()
        {
            string path=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialog1.InitialDirectory = path;
            this.openFileDialog1.Title = "Seleccione una foto";
            this.openFileDialog1.Filter = "Fotografias|*.jpg";
            this.openFileDialog1.Multiselect = false;
            return true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void subirFoto_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                path = this.openFileDialog1.FileName;
            }
        }
    }
}
