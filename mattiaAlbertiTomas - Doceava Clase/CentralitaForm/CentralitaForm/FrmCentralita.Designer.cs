namespace CentralitaForm
{
    partial class FrmCentralita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaLlamadas = new System.Windows.Forms.ListBox();
            this.llamadaLocal = new System.Windows.Forms.Button();
            this.llamadaProvincial = new System.Windows.Forms.Button();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.terminarLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaLlamadas
            // 
            this.listaLlamadas.FormattingEnabled = true;
            this.listaLlamadas.Location = new System.Drawing.Point(12, 12);
            this.listaLlamadas.Name = "listaLlamadas";
            this.listaLlamadas.Size = new System.Drawing.Size(921, 407);
            this.listaLlamadas.TabIndex = 0;
            // 
            // llamadaLocal
            // 
            this.llamadaLocal.Location = new System.Drawing.Point(12, 461);
            this.llamadaLocal.Name = "llamadaLocal";
            this.llamadaLocal.Size = new System.Drawing.Size(229, 23);
            this.llamadaLocal.TabIndex = 1;
            this.llamadaLocal.Text = "Llamada Local";
            this.llamadaLocal.UseVisualStyleBackColor = true;
            this.llamadaLocal.Click += new System.EventHandler(this.llamadaLocal_Click);
            // 
            // llamadaProvincial
            // 
            this.llamadaProvincial.Location = new System.Drawing.Point(247, 461);
            this.llamadaProvincial.Name = "llamadaProvincial";
            this.llamadaProvincial.Size = new System.Drawing.Size(229, 23);
            this.llamadaProvincial.TabIndex = 2;
            this.llamadaProvincial.Text = "Llamada Provincial";
            this.llamadaProvincial.UseVisualStyleBackColor = true;
            this.llamadaProvincial.Click += new System.EventHandler(this.llamadaProvincial_Click);
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Items.AddRange(new object[] {
            "[Seleccionar Orden]",
            "Ordenar por duración ascendente"});
            this.cmbOrden.Location = new System.Drawing.Point(628, 463);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(285, 21);
            this.cmbOrden.TabIndex = 3;
            this.cmbOrden.SelectedIndexChanged += new System.EventHandler(this.cmbOrden_SelectedIndexChanged);
            // 
            // terminarLlamada
            // 
            this.terminarLlamada.Location = new System.Drawing.Point(482, 461);
            this.terminarLlamada.Name = "terminarLlamada";
            this.terminarLlamada.Size = new System.Drawing.Size(140, 23);
            this.terminarLlamada.TabIndex = 4;
            this.terminarLlamada.Text = "Terminar Llamada";
            this.terminarLlamada.UseVisualStyleBackColor = true;
            this.terminarLlamada.Click += new System.EventHandler(this.terminarLlamada_Click);
            // 
            // FrmCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 519);
            this.Controls.Add(this.terminarLlamada);
            this.Controls.Add(this.cmbOrden);
            this.Controls.Add(this.llamadaProvincial);
            this.Controls.Add(this.llamadaLocal);
            this.Controls.Add(this.listaLlamadas);
            this.Name = "FrmCentralita";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaLlamadas;
        private System.Windows.Forms.Button llamadaLocal;
        private System.Windows.Forms.Button llamadaProvincial;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Button terminarLlamada;
    }
}

