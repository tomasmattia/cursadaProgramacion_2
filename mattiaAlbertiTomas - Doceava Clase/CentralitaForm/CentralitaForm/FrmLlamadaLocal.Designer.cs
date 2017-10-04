namespace CentralitaForm
{
    partial class FrmLlamadaLocal
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
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(12, 180);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(77, 13);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo Llamada";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(12, 196);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(267, 20);
            this.txtCosto.TabIndex = 9;
            // 
            // FrmLlamadaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 299);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Name = "FrmLlamadaLocal";
            this.Text = "FrmLlamadaLocal";
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
    }
}