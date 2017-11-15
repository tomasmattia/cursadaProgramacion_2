using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;
using System.IO;
using System.Xml.Serialization;

namespace ConsolaGuardad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            string dominio=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Alumno unap = new Alumno(1,"Tomas", "Mattia");
            Alumno unap1 = new Alumno(2,"asdasd", "hjkhj");
            Alumno unap2 = new Alumno(3,"asdasdas", "tyutyu");
            lista.Add(unap);
            lista.Add(unap1);
            lista.Add(unap2);
            dominio += @"\personas.txt";
            //Console.WriteLine(dominio);
            //StreamWriter escritor = new StreamWriter(dominio,true);

            //escritor.WriteLine(unap.ToString());
            //escritor.Close();

            XmlSerializer serializa = new XmlSerializer(typeof(List<Persona>));
            TextWriter escritor = new StreamWriter(dominio,false);
            serializa.Serialize(escritor, lista);
            escritor.Close();
            //while (lector.EndOfStream == false)
            //{
            //    linea = lector.ReadLine();
            //    Console.WriteLine(linea);
            //}
            //using (StreamReader lector = new StreamReader(@"D:\personas.txt"))
            //{
            //    while (lector.EndOfStream == false)
            //    {
            //        linea = lector.ReadLine();
            //        Console.WriteLine(linea);
            //    }
            //}
            Console.ReadKey();
            TextReader lector = new StreamReader(dominio);
            List<Persona> lista2 = new List<Persona>();
            lista2 = (List<Persona>)serializa.Deserialize(lector);
            foreach (Alumno p in lista2)
            {
                Console.WriteLine(p.ToString());
            }
            lector.Close();
            Console.ReadKey();
        }
    }
}
