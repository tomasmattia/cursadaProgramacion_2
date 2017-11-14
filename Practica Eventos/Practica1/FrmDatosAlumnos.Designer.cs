namespace Practica1
{
    partial class FrmDatosAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 61);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 102);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 140);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 7);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 46);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 84);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 125);
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.Location = new System.Drawing.Point(64, 403);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(145, 403);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 231);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDatosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(281, 438);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDatosAlumnos";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.aceptarbtn, 0);
            this.Controls.SetChildIndex(this.cancelarbtn, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
