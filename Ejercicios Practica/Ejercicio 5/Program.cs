using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            double aumento = 1;
            double numero;
            double contadorAtras;
            double contadorAdelante;
            double sumaAtras;
            double sumaAdelante;

            Console.Write("Ingrese el numero : ");
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("error, reingrese el numero: ");
            }
            while (aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                for (contadorAtras = 1; contadorAtras < aumento; contadorAtras++)
                {
                    sumaAtras += contadorAtras;
                }

                for (contadorAdelante = aumento + 1; contadorAdelante <= sumaAtras; contadorAdelante++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    {
                        break;
                    }
                    sumaAdelante += contadorAdelante;
                }

                if (sumaAtras == sumaAdelante)
                {
                    Console.WriteLine("Es centro numerico: {0}", aumento);
                }  
            }
            Console.Read();
        }
    }
}
