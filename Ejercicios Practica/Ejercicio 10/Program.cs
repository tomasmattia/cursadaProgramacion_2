using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int altura;
            string asteriscos = "*";
            string espacios = " ";
            int contadorEspacios;
            int contador;
            Console.Write("Ingrese la altura : ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.Write("error, reingrese la altura: ");
                }
                if (altura < 0)
                {
                    Console.Write("error, reingrese la altura (mayor a 0): ");
                }
            } while (altura < 0);
            for (contador = altura; contador > 0; contador--)
            {
                for(contadorEspacios=0;contadorEspacios<= (contador+altura / 2);contadorEspacios++)
                {
                    Console.Write(espacios);
                }
                Console.WriteLine(asteriscos);
                asteriscos += "**";
            }
            Console.Read();
        }
    }
}
