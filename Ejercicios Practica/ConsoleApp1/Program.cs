using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            int ano;
            Console.Write("Ingrese el año : ");
            while (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.Write("error, reingrese el año: ");
            }
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.Write("El año {0} es bisiesto",ano);
            }
            else
            {
                Console.Write("El año {0} no es bisiesto", ano);
            }
            Console.Read();
        }
    }
}
