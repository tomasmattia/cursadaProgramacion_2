using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int minimo, int maximo, int numero)
        {
            bool valorRetorno = false;
            if (numero > minimo && numero < maximo)
            {
                valorRetorno = true;
            }
            return valorRetorno;
        }
    }
}
