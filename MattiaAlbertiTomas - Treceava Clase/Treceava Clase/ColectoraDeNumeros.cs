using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treceava_Clase
{
    public class ColectoraDeNumeros
    {
        private List<Numero> _numeros;

        public ETipoNumero Numeros { get; set; }

        public double Suma 
        {
            get
            {
                return ObtenerResultados(this, ETipoResultado.Suma);
            }
        }

        public double Resta
        {
            get
            {
                return ObtenerResultados(this, ETipoResultado.Resta);
            }
        }

        public double Multiplicacion
        {
            get
            {
                return ObtenerResultados(this, ETipoResultado.Multiplicacion);
            }
        }

        public double Division
        {
            get
            {
                return ObtenerResultados(this, ETipoResultado.Division);
            }
        }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo)
            : this()
        {
            this.Numeros = tipo;
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros unaColectora, Numero unNumero)
        {
            try
            {
                if (Verificadora.VerificarNumero(unNumero, unaColectora.Numeros))
                {
                    unaColectora._numeros.Add(unNumero);
                }
                else
                {
                    throw new InvalidProgramException("\nEl numero "+unNumero.MiNumero +" no concuerda con el tipo de la lista\n");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return unaColectora;
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros unaColectora, Numero unNumero)
        {
            unaColectora._numeros.Remove(unNumero);
            return unaColectora;
        }

        public override string ToString()
        {
            string retorno="";
            retorno += "Tipo de numeros: " + this.Numeros.ToString() + "\n";
            foreach (Numero numero in this._numeros)
            {
                retorno += numero.MiNumero+"\n";
            }
            return retorno;
        }

        protected static double ObtenerResultados(ColectoraDeNumeros unaColectora, ETipoResultado tipoResultado)
        {
            try
            {
                double valorRetorno = unaColectora._numeros[0].MiNumero;
                bool banderaPrimero = false;
                foreach (Numero numero in unaColectora._numeros)
                {
                    if (banderaPrimero == false)
                    {
                        banderaPrimero = true;
                        continue;
                    }
                    if (tipoResultado == ETipoResultado.Suma)
                    {
                        valorRetorno += numero.MiNumero;
                    }
                    else
                    {
                        if (tipoResultado == ETipoResultado.Resta)
                        {
                            valorRetorno -= numero.MiNumero;
                        }
                        else
                        {
                            if (tipoResultado == ETipoResultado.Multiplicacion)
                            {
                                valorRetorno *= numero.MiNumero;
                            }
                            else
                            {
                                valorRetorno /= numero.MiNumero;
                            }
                        }
                    }
                }
                return valorRetorno;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("La colectora es null");
                return 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Se genera una division por 0");
                return 0;
            }
        }
    }
}
