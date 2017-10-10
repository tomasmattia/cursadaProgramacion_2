using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treceava_Clase
{
    public static class Verificadora
    {
        public static bool VerificarNumero(Numero unNumero, ETipoNumero tipo)
        {
            if (unNumero.MiNumero % 2 == 0 && tipo == ETipoNumero.Par)
            {
                return true;
            }
            if (unNumero.MiNumero % 2 != 0 && tipo == ETipoNumero.Impar)
            {
                return true;
            }
            if (unNumero.MiNumero > 0 && tipo == ETipoNumero.Positivo)
            {
                return true;
            }
            if (unNumero.MiNumero < 0 && tipo == ETipoNumero.Negativo)
            {
                return true;
            }
            if (unNumero.MiNumero == 0 && tipo == ETipoNumero.Cero)
            {
                return true;
            }
            return false;
        }
    }
}
