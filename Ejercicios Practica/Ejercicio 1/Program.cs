using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int numero = 0;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            float suma = 0;
            int contador;
            for (contador=0;contador<5;contador++)
            {
                Console.Write("Ingrese el numero {0}: ", (contador + 1));
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el numero: ");
                }
                suma += numero;
                if(contador==0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }
                else
                {
                    if(numero>numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    else
                    {
                        if(numero<numeroMinimo)
                        {
                            numeroMinimo = numero;
                        }
                    }
                }
            }
            suma = suma / contador;
            Console.WriteLine("El numero maximo es " + numeroMaximo);
            Console.WriteLine("El numero minimo es " + numeroMinimo);
            Console.WriteLine("El promedio es " + suma);
            Console.Read();
        }
    }
}
