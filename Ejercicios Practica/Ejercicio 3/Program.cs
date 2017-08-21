using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int numero;
            int divisores=0;
            int contadorNumeros;
            int contadorPrimos;

            Console.Write("Ingrese el numero : ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("error, reingrese el numero: ");
            }
            for(contadorNumeros=2; contadorNumeros<numero;contadorNumeros++)
            {
                divisores = 0;
                for (contadorPrimos = 1; contadorPrimos < (contadorNumeros / 2)+1; contadorPrimos++)
                {
                    if (divisores < 2)
                    {
                        if (contadorNumeros % contadorPrimos == 0)
                        {
                            divisores++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if(divisores<2)
                {
                    Console.WriteLine(contadorNumeros);
                }
            }
            Console.Read();
        }
    }
}
