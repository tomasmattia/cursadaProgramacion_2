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
    }
}
