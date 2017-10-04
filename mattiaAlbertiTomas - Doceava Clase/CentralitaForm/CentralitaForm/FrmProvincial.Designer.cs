namespace CentralitaForm
{
    partial class FrmProvincial
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblFranja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblFranja
            // 
            this.lblFranja.AutoSize = true;
            this.lblFranja.Location = new System.Drawing.Point(12, 175);
            this.lblFranja.Name = "lblFranja";
            this.lblFranja.Size = new System.Drawing.Size(73, 13);
            this.lblFranja.TabIndex = 9;
            this.lblFranja.Text = "Franja Horaria";
            // 
            // FrmProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(291, 300);
            this.Controls.Add(this.lblFranja);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmProvincial";
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.lblFranja, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblFranja;
    }
}
