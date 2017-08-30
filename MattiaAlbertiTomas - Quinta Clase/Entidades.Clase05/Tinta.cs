using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;
        public Tinta()
        {
            this._color=ConsoleColor.Black;
            this._tipo=ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color)
            : this()
        {
            this._color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo)
            : this(color)
        {
            this._tipo = tipo;
        }
        private string Mostrar()
        {
            return "Color: "+this._color+"\nTipo: "+this._tipo;
        }
        public static string Mostrar(Tinta unaTinta)
        {
            Console.ForegroundColor = unaTinta._color;
            return unaTinta.Mostrar();
        }
        public static bool operator ==(Tinta unaTinta, Tinta otraTinta)
        {
            return unaTinta._color == otraTinta._color && unaTinta._tipo == otraTinta._tipo;
        }
        public static bool operator != (Tinta unaTinta, Tinta otraTinta)
        {
            return !(unaTinta == otraTinta);
        }
        public static implicit operator string (Tinta unaTinta)
        {
            return unaTinta.Mostrar();
        }
        //public static implicit operator ETipoTinta(Tinta unaTinta)
        //{
        //    return unaTinta._tipo;
        //}
    }
}
