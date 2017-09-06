using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase06
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaColores;

        private Paleta():this(5)
        {   
        }
        private Paleta(int cantidad)
        {
            this._cantMaximaColores = cantidad;
            this._colores = new Tempera[this._cantMaximaColores];
        }

        static public implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string retorno = "Cantidad colores: " + this._cantMaximaColores;
            retorno+="\nTemperas :\n";
            for(int index=0; index< this._cantMaximaColores;index++)
            {
                if (this._colores.GetValue(index) != null)
                {
                    retorno += Tempera.Mostrar(this._colores[index]) + "\n";
                }
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
            for(int index=0; index <unaPaleta._cantMaximaColores;index++)
            {
                if (unaPaleta._colores.GetValue(index) != null)
                {
                    if (unaPaleta._colores[index] == unaTempera)
                    {
                        valorRetorno = true;
                        break;
                    }
                }
            }
            return valorRetorno;
        }

        static public bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        private int BuscarEspacio()
        {
            int valorRetorno = -1;
            for(int index=0; index<this._cantMaximaColores;index ++)
            {
                if (this._colores.GetValue(index) == null)
                {
                    valorRetorno = index;
                    break;
                }
            }
            return valorRetorno;
        }

        private int BuscarTempera(Tempera unaTempera)
        {
            int valorRetorno = -1;
            for (int index = 0; index < this._cantMaximaColores; index++)
            {
                if (this._colores.GetValue(index) != null)
                {
                    if (this._colores[index] == unaTempera)
                    {
                        valorRetorno = index;
                        break;
                    }
                }
            }
            return valorRetorno;
        }

        static public Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            if (unaPaleta != unaTempera)
            {
                if (unaPaleta.BuscarEspacio() >= 0)
                {
                    unaPaleta._colores[unaPaleta.BuscarEspacio()] = unaTempera;
                }
            }
            else
            {
                if (unaPaleta.BuscarTempera(unaTempera) >= 0)
                {
                    unaPaleta._colores[unaPaleta.BuscarTempera(unaTempera)] += unaTempera;
                }
            }
            return unaPaleta;
        }

        static public Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            if (unaPaleta == unaTempera)
            {
                if (unaPaleta.BuscarTempera(unaTempera) >= 0)
                {
                    unaPaleta._colores[unaPaleta.BuscarTempera(unaTempera)] = null;
                }
            }
            return unaPaleta;
        }
        static public Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            Paleta nuevaPaleta = unaPaleta._cantMaximaColores+otraPaleta._cantMaximaColores;
            for (int index = 0; index < unaPaleta._cantMaximaColores; index++)
            {
                if (unaPaleta._colores.GetValue(index) != null)
                {
                    nuevaPaleta += unaPaleta._colores[index];
                }
            }
            for (int index = 0; index < otraPaleta._cantMaximaColores; index++)
            {
                if (otraPaleta._colores.GetValue(index) != null)
                {
                    nuevaPaleta += otraPaleta._colores[index];
                }
            }
            return nuevaPaleta;
        }
    }
}
