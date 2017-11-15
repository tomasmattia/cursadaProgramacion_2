using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string ElColor { get { return _color; } }
        public string LaMarca { get { return _marca; } }

        public Auto()
        {
            this._color = "Sin Cargar";
            this._marca = "Sin Cargar";
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            return obj is Auto && this == (Auto)obj;
        }

        public static bool operator ==(Auto unAuto, Auto otroAuto)
        {
            return unAuto._color == otroAuto._color && unAuto._marca == otroAuto._marca; 
        }

        public static bool operator !=(Auto unAuto, Auto otroAuto)
        {
            return !(unAuto == otroAuto);
        }

        public override string ToString()
        {
            return "Marca: " + this._marca + " - Color: " + this._color + "\n";
        }
    }
}
