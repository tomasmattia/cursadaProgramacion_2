using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";
            int altura;
            string asteriscos = "*";
            int contador;
            Console.Write("Ingrese la altura : ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.Write("error, reingrese la altura: ");
                }
                if(altura<0)
                {
                    Console.Write("error, reingrese la altura (mayor a 0): ");
                }
            } while (altura < 0);
            for(contador=0;contador<altura;contador++)
            {
                Console.WriteLine(asteriscos);
                asteriscos += "**";
            }
            Console.Read();
        }
    }
}
