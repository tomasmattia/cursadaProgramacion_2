using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRM_Paleta
{
    public class Tempera
    {
        private ConsoleColor _color;
        public ConsoleColor Color
        {
            get { return _color; }
        }
        private string _marca;

        public string Marca
        {
            get { return _marca; }
        }
        
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
            return "Color: " + this.Color + "/ Marca: " + this.Marca + "/ Cantidad: " + this._cantidad;
        }

        static public string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }
        static public bool operator ==(Tempera unaTempera, Tempera otraTempera)
        {
            return unaTempera.Color == otraTempera.Color && unaTempera.Marca == otraTempera.Marca;
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
