using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public Tempera()
        {
            this._color = ConsoleColor.Black;
            this._marca = "Sin Marca";
            this._cantidad = 0;
        }

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return "Color: " + this._color + "  Marca: " + this._marca + "  Cantidad: " + this._cantidad+"\n";
        }

        static public string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }

        static public bool operator ==(Tempera unaTempera, Tempera otraTempera)
        {
            return unaTempera._color == otraTempera._color && unaTempera._marca == otraTempera._marca;
        }

        static public bool operator !=(Tempera unaTempera, Tempera otraTempera)
        {
            return !(unaTempera == otraTempera);
        }

        static public Tempera operator +(Tempera unaTempera, double cantidad)
        {
            if (cantidad > 0 && unaTempera._cantidad + cantidad <= 100)
            {
                unaTempera._cantidad += (int)cantidad;
            }
            else 
            {
                if (unaTempera._cantidad + cantidad > 100)
                {
                    unaTempera._cantidad = 100;
                }
            }
            return unaTempera;
        }

        static public implicit operator int(Tempera unaTempera)
        {
            return unaTempera._cantidad;
        }
    }
}
