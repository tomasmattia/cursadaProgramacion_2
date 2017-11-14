namespace Practica1
{
    partial class FrmTestDelegados
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
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.actualizar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.subirFoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(12, 77);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(260, 20);
            this.nombreBox.TabIndex = 0;
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(100, 198);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 23);
            this.actualizar.TabIndex = 1;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // subirFoto
            // 
            this.subirFoto.Location = new System.Drawing.Point(100, 169);
            this.subirFoto.Name = "subirFoto";
            this.subirFoto.Size = new System.Drawing.Size(75, 23);
            this.subirFoto.TabIndex = 2;
            this.subirFoto.Text = "Subir Foto";
            this.subirFoto.UseVisualStyleBackColor = true;
            this.subirFoto.Click += new System.EventHandler(this.subirFoto_Click);
            // 
            // FrmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.subirFoto);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.nombreBox);
            this.Name = "FrmTestDelegados";
            this.Text = "FrmTestDelegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button subirFoto;
    }
}