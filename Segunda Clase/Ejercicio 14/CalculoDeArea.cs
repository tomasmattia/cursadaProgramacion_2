using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double valorRetorno;
            valorRetorno = lado * lado;
            return valorRetorno;
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double valorRetorno;
            valorRetorno = (baseTriangulo * altura) / 2;
            return valorRetorno;
        }
        public static double CalcularCirculo(double radio)
        {
            double valorRetorno;
            valorRetorno = (radio * radio) * Math.PI;
            return valorRetorno;
        }
    }
}
