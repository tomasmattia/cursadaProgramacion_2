using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Entidades
{
    //public delegate void EventHandler(object a);
    public class Cartuchera<T>
    {
        protected string marca;
        protected int capacidad;
        protected List<T> lista;
        public T ultimoAgregado;
        public event EventHandler eventEscribir;

        public Cartuchera(string marca, int capacidad)
        {
            this.marca = marca;
            this.capacidad = capacidad;
            this.lista = new List<T>();
            eventEscribir += new EventHandler(Archivos.Escribir);
        }

        public Cartuchera()
        {
            this.marca = "Sin marca";
            this.capacidad = 5;
            this.lista = new List<T>();
            eventEscribir += new EventHandler(Archivos.Escribir);
        }

        public void Agregar(T item)
        {
            try
            {
                if (this.lista.Count < this.capacidad)
                    lista.Add(item);
                ultimoAgregado = item;
                eventEscribir(this, EventArgs.Empty);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public bool Guardar()
        {
            using (StreamWriter sw = new StreamWriter("cartuchera.xml", false))
            {
                XmlSerializer xmls = new XmlSerializer(this.GetType(), new Type[] { typeof(Utiles), typeof(Lapicera), typeof(Goma) });
                xmls.Serialize(sw, this);
            }
            return true;
        }

        /*public string Leer()
        {
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\cartuchera.xml"))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                List<Persona> misPersonas = new List<Persona>();
                misPersonas = (List<Persona>)xmls.Deserialize(sr);
                foreach (Persona p in misPersonas)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }*/

    }
}