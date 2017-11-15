using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personas;
using System.IO;
using System.Xml.Serialization;

namespace FormGuardar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Persona unaP = new Persona("Nofu", "nciona");   
            this.saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.saveFileDialog1.Filter = "Archivo de Texto | *.txt";
            this.saveFileDialog1.DefaultExt = ".txt";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = this.saveFileDialog1.FileName ;
                StreamWriter guardar = new StreamWriter(ruta, false);
                
                guardar.Close();

            }


        }

        private void Leer_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.openFileDialog1.OpenFile();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string linea = "";
            using (StreamReader lector = new StreamReader(@"D:\personas.txt"))
            {
                while (lector.EndOfStream == false)
                {
                    linea = lector.ReadLine();
                }
                MessageBox.Show(linea);
            }
        }
    }
}
