using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double numero;
            double numeroAux;
            double resultado;
            Console.WriteLine("MENU");
            Console.WriteLine("1- AREA CUADRADO");
            Console.WriteLine("2- AREA CIRCULO");
            Console.WriteLine("3- AREA TRIANGULO");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out respuesta))
                {
                    Console.Write("error, opcion invalida: ");
                }
                if (respuesta > 3 || respuesta < 1)
                {
                    Console.Write("error, opcion invalida: ");
                }
            } while (respuesta > 3 || respuesta < 1);
            if(respuesta==1)
            {
                Console.Write("ingrese un lado del cuadrado: ");
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("error, reingrese el lado: ");
                }
                resultado = CalculoDeArea.CalcularCuadrado(numero);
                Console.WriteLine("El area del cuadrado es " + resultado);
                Console.Read();
            }
            else
            {
                if(respuesta==2)
                {
                    Console.Write("ingrese la base del triangulo: ");
                    while (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("error, reingrese la base del triangulo: ");
                    }
                    Console.Write("ingrese la altura del triangulo: ");
                    while (!double.TryParse(Console.ReadLine(), out numeroAux))
                    {
                        Console.Write("error, reingrese la altura del triangulo: ");
                    }
                    resultado = CalculoDeArea.CalcularTriangulo(numero, numeroAux);
                    Console.WriteLine("El area del triangulo es " + resultado);
                    Console.Read();
                }
                else
                {
                    Console.Write("ingrese el radio del circulo: ");
                    while (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Write("error, reingrese el radio: ");
                    }
                    resultado = CalculoDeArea.CalcularCirculo(numero);
                    Console.WriteLine("El area del circulo es " + resultado);
                    Console.Read();
                }
            }
        }
    }
}
