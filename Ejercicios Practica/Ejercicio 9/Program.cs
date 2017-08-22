using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            int valorHora;
            string nombre;
            int antiguedad;
            int horasDeTrabajo;
            float cuantoCobra;
            float descuentos;
            char seguir = 's';
            while (seguir != 'n')
            {
                Console.Write("Ingrese valor de la hora: ");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out valorHora))
                    {
                        Console.Write("error, reingrese el valor: ");
                    }
                    if (valorHora < 0)
                    {
                        Console.Write("error, debe ser un valor positivo: ");
                    }
                } while (valorHora < 0);

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la antiguedad: ");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out antiguedad))
                    {
                        Console.Write("error, reingrese la antiguedad: ");
                    }
                    if (antiguedad < 0)
                    {
                        Console.Write("error, debe ser positivo: ");
                    }
                } while (antiguedad < 0);
                Console.Write("Ingrese horas trabajadas: ");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out horasDeTrabajo))
                    {
                        Console.Write("error, reingrese las horas: ");
                    }
                    if (horasDeTrabajo < 0)
                    {
                        Console.Write("error, debe ser positivo: ");
                    }
                } while (horasDeTrabajo < 0);

                cuantoCobra = (valorHora * horasDeTrabajo + antiguedad * 150);
                descuentos = cuantoCobra * (float)0.87;

                Console.Clear();

                Console.WriteLine("RECIBO");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("La antiguedad: " + antiguedad);
                Console.WriteLine("El valor de la hora es : " + valorHora);
                Console.WriteLine("Sueldo en bruto: {0:N2}", cuantoCobra);
                Console.WriteLine("Total de descuentos: {0:N2}", descuentos);
                Console.WriteLine("Sueldo en neto: {0:N2}", cuantoCobra - descuentos);

                do
                {
                    Console.Write("\nDesea ingresar otro empleado? (s/n): ");
                    seguir = char.Parse(Console.ReadLine());
                } while (seguir != 's' && seguir != 'n');

                Console.Clear();
            }
        }
    }
}
