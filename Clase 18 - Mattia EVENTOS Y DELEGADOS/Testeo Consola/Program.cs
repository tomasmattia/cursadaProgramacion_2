using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Testeo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado();
            try
            {
                e1.Nombre = "Jorge";
                e1.Apellido = "Perez";
                e1.limiteSueldo += new DelEmp(ManejadorEvento);
                e1.EmpleadoBoton += new ElBoton(new Program().ManejadorBoton);
                e1.EmpleadoReBoton += new ElReBoton(new Program().ManejadorReBoton);
                e1.Sueldo = 9501;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static void ManejadorEvento()
        {
            Console.WriteLine("Handling limite sueldo");
        }

        public void ManejadorEvento2()
        {
            Console.WriteLine("Handling 2 limite sueldo");
        }

        public void ManejadorBoton(Empleado e)
        {
            Console.WriteLine("Este se esta subiendo el sueldo "+e.Apellido+", "+e.Nombre);
        }

        public void ManejadorReBoton(Empleado e,double crimen)
        {
            Console.WriteLine("Este se esta subiendo el sueldo " + e.Apellido + ", " + e.Nombre+" a "+crimen.ToString());
        }
    }
}
