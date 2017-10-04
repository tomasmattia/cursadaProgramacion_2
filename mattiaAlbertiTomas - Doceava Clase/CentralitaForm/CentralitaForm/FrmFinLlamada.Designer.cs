namespace CentralitaForm
{
    partial class FrmFinLlamada
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
            this.costoFinal = new System.Windows.Forms.TextBox();
            this.tiempoInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // costoFinal
            // 
            this.costoFinal.Location = new System.Drawing.Point(12, 181);
            this.costoFinal.Name = "costoFinal";
            this.costoFinal.Size = new System.Drawing.Size(267, 20);
            this.costoFinal.TabIndex = 8;
            // 
            // tiempoInicio
            // 
            this.tiempoInicio.Location = new System.Drawing.Point(12, 134);
            this.tiempoInicio.Name = "tiempoInicio";
            this.tiempoInicio.Size = new System.Drawing.Size(267, 20);
            this.tiempoInicio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inicio";
            // 
            // FrmFinLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiempoInicio);
            this.Controls.Add(this.costoFinal);
            this.Name = "FrmFinLlamada";
            this.Text = "FrmFinLlamada";
            this.Controls.SetChildIndex(this.txtOrigen, 0);
            this.Controls.SetChildIndex(this.txtDestino, 0);
            this.Controls.SetChildIndex(this.costoFinal, 0);
            this.Controls.SetChildIndex(this.tiempoInicio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costoFinal;
        private System.Windows.Forms.TextBox tiempoInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}