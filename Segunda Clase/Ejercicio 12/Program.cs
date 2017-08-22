using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            do
            {
                Console.Write("ingrese el numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el numero: ");
                }
                acumulador += numero;
            } while (ValidarRespuesta.ValidaS_N() == true);
            Console.Read();
        }
    }
}
