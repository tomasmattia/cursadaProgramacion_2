namespace FRMProveedorPersonas
{
    partial class FRMPrincipal
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
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregar.Location = new System.Drawing.Point(29, 257);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "AGREGAR";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.Khaki;
            this.modificar.Location = new System.Drawing.Point(110, 257);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "MODIFICAR";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Firebrick;
            this.borrar.Location = new System.Drawing.Point(191, 257);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "BORRAR";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 251);
            this.dataGridView1.TabIndex = 4;
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(364, 257);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(75, 23);
            this.backup.TabIndex = 5;
            this.backup.Text = "BACKUP";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 285);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FRMPrincipal";
            this.Text = "FRMPrincipal";
            this.Load += new System.EventHandler(this.FRMPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backup;
    }
}

