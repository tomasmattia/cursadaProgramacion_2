﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string number=Convert.ToString(numero);
            int fromBase = 10;
            int toBase = 2;
            string valorRetorno = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            return valorRetorno;
        }
        public static double BinarioDecimal(string number)
        {
            double valorRetorno = Convert.ToInt64(number, 2);
            return valorRetorno;
        }
    }
}
