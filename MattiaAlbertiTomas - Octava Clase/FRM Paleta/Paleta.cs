using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRM_Paleta
{
    public class Paleta
    {
        private List<Tempera> _colores = new List<Tempera>();
        private int _cantMaximaColores;

        private Paleta()
            : this(5)
        {
        }
        private Paleta(int cantidad)
        {
            this._cantMaximaColores = cantidad;
        }

        static public implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string retorno = "";
            for (int index = 0; index < this._colores.Count; index++)
            {
                retorno += Tempera.Mostrar(this._colores[index]);
            }
            return retorno;
        }

        static public explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrar();
        }

        static public bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool valorRetorno = false;
            for (int index = 0; index < unaPaleta._colores.Count; index++)
            {
                if (unaPaleta._colores[index] == unaTempera)
                {
                    valorRetorno = true;
                    break;
                }
            }
            return valorRetorno;
        }

        static public bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        static public Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            int maximo=unaPaleta._colores.Count;
            if (unaPaleta != unaTempera && maximo<unaPaleta._cantMaximaColores)
            {
                unaPaleta._colores.Add(unaTempera);
            }
            else
            {
                for (int contador = 0; contador < maximo;contador++ )
                {
                    if (unaTempera == unaPaleta._colores[contador])
                    {
                        unaPaleta._colores[contador] += unaTempera;
                        break;
                    }
                }
            }
            return unaPaleta;
        }

        static public Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            int maximo = unaPaleta._colores.Count;
            if (unaPaleta == unaTempera)
            {
                for (int contador = 0; contador < maximo; contador++)
                {
                    if (unaPaleta._colores[contador] == unaTempera)
                    {
                        unaPaleta._colores.RemoveAt(contador);
                        break;
                    }
                }
            }
            return unaPaleta;
        }
        static public Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            Paleta nuevaPaleta = unaPaleta._cantMaximaColores + otraPaleta._cantMaximaColores;
            for (int index = 0; index < unaPaleta._cantMaximaColores; index++)
            {
                nuevaPaleta += unaPaleta._colores[index];
            }
            for (int index = 0; index < otraPaleta._cantMaximaColores; index++)
            {
                nuevaPaleta += otraPaleta._colores[index];
            }
            return nuevaPaleta;
        }
        public List<Tempera> getTemperas()
        {
            return this._colores;
        }
    }
}
