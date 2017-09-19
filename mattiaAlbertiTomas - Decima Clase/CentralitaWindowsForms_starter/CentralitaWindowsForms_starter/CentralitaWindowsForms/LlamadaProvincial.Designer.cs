namespace CentralitaWindowsForms
{
    partial class LlamadaProvincial
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
            this.franjaCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // franjaCombo
            // 
            this.franjaCombo.FormattingEnabled = true;
            this.franjaCombo.Items.AddRange(new object[] {
            "Franja Horaria 1",
            "Franja Horaria 2",
            "Franja Horaria 3"});
            this.franjaCombo.Location = new System.Drawing.Point(15, 179);
            this.franjaCombo.Name = "franjaCombo";
            this.franjaCombo.Size = new System.Drawing.Size(188, 21);
            this.franjaCombo.TabIndex = 8;
            this.franjaCombo.SelectedIndexChanged += new System.EventHandler(this.franjaCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Franja";
            // 
            // LlamadaProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.franjaCombo);
            this.Name = "LlamadaProvincial";
            this.Text = "LlamadaProvincial";
            this.Load += new System.EventHandler(this.LlamadaProvincial_Load);
            this.Controls.SetChildIndex(this.franjaCombo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox franjaCombo;
        private System.Windows.Forms.Label label4;
    }
}