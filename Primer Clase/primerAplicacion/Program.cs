using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;
            string dato;
            bool esNumero;

            Console.Write("Ingrese el numero uno: ");

            while(!int.TryParse(Console.ReadLine(),out numeroUno))
            {
                Console.Write("error, reingrese el numero uno: ");
            }

            Console.Write("Ingrese el numero dos: ");

            while (!int.TryParse(Console.ReadLine(), out numeroDos))
            {
                Console.Write("error, reingrese el numero uno: ");
            }

            //dato = Console.ReadLine();
            //esNumero = int.TryParse(dato, out numeroUno);
            //Console.Write("Ingrese el numero dos: ");
            //dato = Console.ReadLine();
            //esNumero = int.TryParse(dato, out numeroDos);
            resultado = numeroDos + numeroUno;
            Console.Write("El resultado es: {0}",resultado);
            Console.Read();
        }
    }
}
