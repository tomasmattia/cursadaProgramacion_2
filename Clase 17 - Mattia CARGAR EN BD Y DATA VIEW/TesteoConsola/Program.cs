using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TesteoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ProveedorDeDatos unProveedor = new ProveedorDeDatos();
            foreach(Persona p in unProveedor.ObtenerPersonasBD())
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.WriteLine(unProveedor.ObtenerPersonaIdBD(2).ToString());
            Console.ReadKey();
            Console.WriteLine("\n");
            try
            {
                Console.WriteLine(ProveedorDeDatos.ObtenerPersonaID(5).ToString());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Se busco un id que no existe");
            }
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
