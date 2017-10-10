using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treceava_Clase
{
    public class Numero
    {
        protected int _numero;

        public int MiNumero
        {
            get { return _numero; }
        }

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public static int operator +(Numero unNumero,Numero otroNumero)
        {
            return unNumero._numero + otroNumero._numero;
        }

        public static int operator -(Numero unNumero, Numero otroNumero)
        {
            return unNumero._numero - otroNumero._numero;
        }

        public static int operator *(Numero unNumero, Numero otroNumero)
        {
            return unNumero._numero * otroNumero._numero;
        }

        public static double operator /(Numero unNumero, Numero otroNumero)
        {
            try
            {
                return (double)(unNumero._numero /otroNumero._numero);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("No se puede dividir por 0");
                return 0;
            }
        }
        
    }
}
