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
            for (int i = 0; i < this._cantMaximaColores; i++)
            {
                this._colores[i] = new Tempera();
            }
        }

        static public implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string retorno = "Cantidad colores: " + this._cantMaximaColores;
            retorno+="\nTemperas :\n";
            foreach(Tempera temp in this._colores)
            {
                retorno+=Tempera.Mostrar(temp)+"\n";
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
            foreach(Tempera temp in unaPaleta._colores)
            {
                if(temp==unaTempera)
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

        static private int BuscarEspacio(Paleta unaPaleta)
        {
            int valorRetorno = -1;
            for(int index=0; index<unaPaleta._cantMaximaColores;index ++)
            {
                if (unaPaleta._colores[index] == null)
                {
                    valorRetorno = index;
                }
            }
            return valorRetorno;
        }

        static private int BuscarTempera(Paleta unaPaleta, Tempera unaTempera)
        {
            int valorRetorno = -1;
            for (int index = 0; index < unaPaleta._cantMaximaColores; index++)
            {
                if (unaPaleta._colores[index] == unaTempera)
                {
                    valorRetorno = index;
                }
            }
            return valorRetorno;
        }

        static public Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            if(unaPaleta!=unaTempera)
            {
                if(Paleta.BuscarEspacio(unaPaleta)>0)
                {
                    unaPaleta._colores[Paleta.BuscarEspacio(unaPaleta)] = unaTempera;
                }
            }
            return unaPaleta;
        }

        static public Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            if (unaPaleta == unaTempera)
            {
                if (Paleta.BuscarEspacio(unaPaleta) > 0)
                {
                    unaPaleta._colores[Paleta.BuscarEspacio(unaPaleta)] = null;
                }
            }
            return unaPaleta;
        }
    }
}
