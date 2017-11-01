using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Xml.Serialization;
using System.IO;


namespace FRMProveedorPersonas
{
    public partial class FRMPrincipal : Form
    {
        List<Persona> listaPersonas;
        ProveedorDeDatos provD;
        DataTable mytable;
        public FRMPrincipal()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();
            provD = new ProveedorDeDatos();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarMain();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            FRMabm frmAbm = new FRMabm();
            frmAbm.ShowDialog();
            if (frmAbm.DialogResult == DialogResult.OK)
            {
                provD.AgregarPersonaDB(frmAbm.PersonaDelFrom);
                ActualizarMain();
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FRMabm frmAbm = new FRMabm(this.listaPersonas[dataGridView1.SelectedRows]);
            //    frmAbm.ShowDialog();
            //    if (frmAbm.DialogResult == DialogResult.OK)
            //    {
            //        provD.ModificarPersonaBD(frmAbm.PersonaDelFrom);
            //        ActualizarMain();
            //    }
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show(x.Message);
            //}
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FRMabm frmAbm = new FRMabm(this.listaPersonas[dataGridView1.SelectedRows[0].Cast<int>]);
            //    frmAbm.ShowDialog();
            //    if (frmAbm.DialogResult == DialogResult.OK)
            //    {
            //        provD.EliminarPersonaDB(frmAbm.PersonaDelFrom);
            //        ActualizarMain();
            //    }
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show(x.Message);
            //}
        }

        private void ActualizarMain()
        {
            listaPersonas = provD.ObtenerPersonasBD();
            mytable= provD.ObtenerPersonasBD(true);
            this.dataGridView1.DataSource = mytable;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void backup_Click(object sender, EventArgs e)
        {
            DataRow f = mytable.NewRow();
            f["id"] = 10;
            f["apellido"]="Queres";
            f["nombre"]="UnGlobo";
            f["edad"] = 20;
            mytable.Rows.Add(f);
            mytable.WriteXmlSchema("baseDeDatos.xml");
            mytable.WriteXml("baseDeDatos.xml");
            
        }
    }
}
