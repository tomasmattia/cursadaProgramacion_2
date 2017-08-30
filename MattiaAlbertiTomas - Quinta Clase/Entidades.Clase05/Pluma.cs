using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;
        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }
        public Pluma(string marca):this()
        {
            this._marca = marca;
        }
        public Pluma(string marca,Tinta unaTinta):this(marca)
        {
            this._tinta = unaTinta;
        }
        public Pluma(string marca, Tinta unaTinta, int cantidad)
            : this(marca, unaTinta)
        {
            this._cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "Marca: " + this._marca + "\nTinta: " + (string)this._tinta + "\nCantidad: " + this._cantidad;
        }

        public static bool operator ==(Pluma unaPluma, Tinta unaTinta)
        {
            return unaTinta == unaPluma._tinta;
        }
        public static bool operator !=(Pluma unaPluma, Tinta unaTinta)
        {
            return !(unaTinta == unaPluma._tinta);
        }
        public static Pluma operator +(Pluma unaPluma, Tinta unaTinta)
        {
            if (unaPluma == unaTinta && unaPluma._cantidad<100)
            {
                unaPluma._cantidad++;
            }
            return unaPluma;
        }
        public static Pluma operator -(Pluma unaPluma, Tinta unaTinta)
        {
            if (unaPluma == unaTinta && unaPluma._cantidad > 0)
            {
                unaPluma._cantidad--;
            }
            return unaPluma;
        }
        public static implicit operator string(Pluma unaPluma)
        {
            return unaPluma.Mostrar();
        }
    }
}
