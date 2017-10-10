﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treceava_Clase;

namespace TesteoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ColectoraDeNumeros cn = new ColectoraDeNumeros(ETipoNumero.Par);

            Numero n1 = new Numero(Int32.Parse("24"));
            Numero n2 = new Numero(Int32.Parse("-56"));
            Numero n3 = new Numero(Int32.Parse("59"));
            Numero n4 = new Numero(Int32.Parse("-18"));
            Numero n5 = new Numero(Int32.Parse("0"));


            int suma = n1 + n2;
            int resta = n3 - n4;
            int multi = n4 * n1;
            int divi = (int)(n3 / n5);

            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multi);
            Console.WriteLine(divi);

            cn += n1;
            cn += n2;
            cn += n3;
            cn += n4;
            cn += n5;

            Console.WriteLine(cn);

            cn -= n3;
            cn -= n4;

            Console.WriteLine(cn);

            Console.ReadLine();

        }
    }
}
