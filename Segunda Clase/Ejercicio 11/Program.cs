using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo=0;
            int minimo=0;
            float promedio;
            float acumulador = 0;
            int contador;
            for (contador = 0; contador < 10; contador++)
            {
                Console.Write("ingrese el numero: ");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("error, reingrese el numero: ");
                    }
                    if (Validacion.Validar(-100, 100, numero) == false)
                    {
                        Console.Write("error, reingrese el numero, entre -100 y 100: ");
                    }
                }while(Validacion.Validar(-100,100,numero)==false);
                acumulador+=numero;
                if (contador == 0)
                {
                    maximo=numero;
                    minimo=numero;
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
            promedio = acumulador / contador;
            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Promedio: " + promedio);
            Console.Read();
        }
    }
}
