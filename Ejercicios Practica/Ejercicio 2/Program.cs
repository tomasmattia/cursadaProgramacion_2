using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            double numero=-1;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese el numero : ");
            do
            {
                while (!double.TryParse(Console.ReadLine(), out numero)) 
                {
                    Console.Write("ERROR. Debe ingresar un numero : ");
                }
                if(numero<0)
                {
                    Console.Write("ERROR. Reingresar número!!! : ");
                }
            } while (numero < 0);

                cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado del numero es " + cuadrado);
            Console.WriteLine("El cubo del numero es " + cubo);
            Console.Read();
        }
    }
}
