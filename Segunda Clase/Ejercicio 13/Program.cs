using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double decimalBinario;
            string binario;
            int respuesta;
            Console.WriteLine("MENU");
            Console.WriteLine("1- CONVERTIR DECIMAL A BINARIO");
            Console.WriteLine("2- CONVERTIR BINARIO A DECIMAL");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out respuesta))
                {
                    Console.Write("error, opcion invalida: ");
                }
                if (respuesta > 2 || respuesta < 1)
                {
                    Console.Write("error, opcion invalida: ");
                }
            } while (respuesta > 2 || respuesta < 1);
            if (respuesta == 1)
            {
                Console.Write("ingrese el numero: ");
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el numero: ");
                }
                binario = Conversor.DecimalBinario(numero);
                Console.WriteLine(binario);
                Console.Read();
            }
            else
            {
                if (respuesta == 2)
                {
                    Console.Write("ingrese el numero: ");
                    binario = Console.ReadLine();
                    decimalBinario = Conversor.BinarioDecimal(binario);
                    Console.WriteLine(decimalBinario);
                    Console.Read();
                }
            }
        }
    }
}
