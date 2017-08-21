using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";
            int sumaDivisores = 0;
            int contadorNumeros = 2;
            int contadorDivisores;
            int cantidadPerfectos = 0;

            while (cantidadPerfectos < 4)
            {
                sumaDivisores = 0;
                for (contadorDivisores = 1; contadorDivisores < contadorNumeros; contadorDivisores++)
                {
                    if (sumaDivisores <= contadorNumeros)
                    {
                        if (contadorNumeros % contadorDivisores == 0)
                        {
                            sumaDivisores += contadorDivisores;
                        }
                    }
                }
                if (sumaDivisores == contadorNumeros)
                {
                    cantidadPerfectos++;
                    Console.WriteLine(contadorNumeros);
                }
                contadorNumeros++;
            }
            Console.Read();
        }
    }
}
