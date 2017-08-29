using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa unaCosa = new Cosa(99,"Pepe",new DateTime(2018,06,06,23,59,59));
            unaCosa.EstablecerValor(ConsoleColor.DarkRed);
            Console.WriteLine(unaCosa.Mostrar());
            Console.ForegroundColor = ConsoleColor.Gray;
            unaCosa.EstablecerValor(Console.ForegroundColor);
            Console.WriteLine(unaCosa.Mostrar());
            Console.Read();
        }
    }
}
