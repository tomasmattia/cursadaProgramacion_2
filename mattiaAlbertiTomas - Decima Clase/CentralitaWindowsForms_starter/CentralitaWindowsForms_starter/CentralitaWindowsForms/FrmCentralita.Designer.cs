namespace CentralitaWindowsForms
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
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.llamadaLocal = new System.Windows.Forms.Button();
            this.llamadaProvincial = new System.Windows.Forms.Button();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVisor
            // 
            this.lstVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(12, 12);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(616, 160);
            this.lstVisor.TabIndex = 0;
            // 
            // llamadaLocal
            // 
            this.llamadaLocal.Location = new System.Drawing.Point(12, 183);
            this.llamadaLocal.Name = "llamadaLocal";
            this.llamadaLocal.Size = new System.Drawing.Size(135, 23);
            this.llamadaLocal.TabIndex = 1;
            this.llamadaLocal.Text = "Llamada Local";
            this.llamadaLocal.UseVisualStyleBackColor = true;
            this.llamadaLocal.Click += new System.EventHandler(this.llamadaLocal_Click);
            // 
            // llamadaProvincial
            // 
            this.llamadaProvincial.Location = new System.Drawing.Point(159, 183);
            this.llamadaProvincial.Name = "llamadaProvincial";
            this.llamadaProvincial.Size = new System.Drawing.Size(135, 23);
            this.llamadaProvincial.TabIndex = 2;
            this.llamadaProvincial.Text = "Llamada Provincial";
            this.llamadaProvincial.UseVisualStyleBackColor = true;
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Location = new System.Drawing.Point(438, 185);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(190, 21);
            this.cboOrdenamiento.TabIndex = 4;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(365, 188);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(67, 13);
            this.lblLabel.TabIndex = 5;
            this.lblLabel.Text = "Ordenar Por:";
            // 
            // FrmCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 218);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.cboOrdenamiento);
            this.Controls.Add(this.llamadaProvincial);
            this.Controls.Add(this.llamadaLocal);
            this.Controls.Add(this.lstVisor);
            this.Name = "FrmCentralita";
            this.Text = "Centralita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.Button llamadaLocal;
        private System.Windows.Forms.Button llamadaProvincial;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Label lblLabel;
    }
}

