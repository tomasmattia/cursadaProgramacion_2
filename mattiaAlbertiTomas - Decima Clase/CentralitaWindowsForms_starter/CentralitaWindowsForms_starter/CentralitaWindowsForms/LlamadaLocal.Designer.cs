namespace CentralitaWindowsForms
{
    partial class LlamadaLocal
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
            this.costoLlamada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // costoLlamada
            // 
            this.costoLlamada.Location = new System.Drawing.Point(15, 179);
            this.costoLlamada.Name = "costoLlamada";
            this.costoLlamada.Size = new System.Drawing.Size(188, 20);
            this.costoLlamada.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Costo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LlamadaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costoLlamada);
            this.Name = "LlamadaLocal";
            this.Text = "LlamadaLocal";
            this.Load += new System.EventHandler(this.LlamadaLocal_Load);
            this.Controls.SetChildIndex(this.costoLlamada, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costoLlamada;
        private System.Windows.Forms.Label label4;
    }
}