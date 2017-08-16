using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo=0;
            int minimo=0;
            for (int contador = 0; contador < 5; contador++)
            {
                Console.Write("Ingrese el numero {0}: ", (contador + 1));

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el numero: ");
                }
                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                }
            }
            Console.WriteLine("El maximo ingresado es " + maximo);
            Console.WriteLine("El minimo ingresado es " + minimo);
            Console.Read();

        }
    }
}
