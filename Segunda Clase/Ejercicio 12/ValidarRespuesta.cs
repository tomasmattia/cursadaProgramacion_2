using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            bool valorRetorno = false;
            string respuesta;
            Console.WriteLine("Desea continuar sumando numeros?");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Debe responder con s o n, desea continuar?");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "s")
            {
                valorRetorno = true;
            }

            return valorRetorno;
        }

    }
}
