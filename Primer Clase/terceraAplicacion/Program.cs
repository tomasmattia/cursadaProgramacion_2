using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terceraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cantidadPares = 0;
            int primerPar = 0;
            int lugarPrimerPar = 0;
            int ultimoImpar = 0;
            int lugarUltimoImpar = 0;
            int maximo = 0;
            int minimo = 0;
            float suma = 0;
            float promedio=0;
            int contador;
            for (contador = 0; contador < 7; contador++)
            {
                Console.Write("Ingrese el numero {0}: ", (contador + 1));
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el numero: ");
                }
                suma += numero;
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
                if (numero % 2 == 0)
                {
                    cantidadPares++;
                    if (primerPar == 0)
                    {
                        primerPar = numero;
                        lugarPrimerPar = contador + 1;
                    }
                }
                if (numero % 2 != 0)
                {
                    ultimoImpar = numero;
                    lugarUltimoImpar = contador + 1;
                }
            }
            promedio = suma / contador;
            Console.WriteLine("El maximo ingresado es " + maximo);
            Console.WriteLine("El minimo ingresado es " + minimo);
            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("El promedio es " + promedio);
            Console.WriteLine("El primer par es " + primerPar);
            Console.WriteLine("El lugar del primer par es " + lugarPrimerPar);
            Console.WriteLine("La cantidad de pares es " + cantidadPares);
            Console.WriteLine("El ultimo impar es " + ultimoImpar);
            Console.WriteLine("El lugar del ultimo impar es " + lugarUltimoImpar);
            Console.Read();
        }
    }
}
