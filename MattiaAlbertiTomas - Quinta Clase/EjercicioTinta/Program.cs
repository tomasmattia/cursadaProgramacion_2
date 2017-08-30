using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase05;

namespace EjercicioTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta unaTinta = new Tinta(ConsoleColor.Magenta, ETipoTinta.China);
            Tinta otraTinta = new Tinta(ConsoleColor.Cyan);
            Pluma unaPluma = new Pluma("PENN",unaTinta);
            Console.WriteLine(unaPluma+unaTinta);
            Console.WriteLine(unaPluma-unaTinta);
            //Console.WriteLine(unaTinta);
            Console.Read();
        }
    }
}
