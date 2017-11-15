using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get { return _codigo; } }

        public bool EsIndustrial { get { return _esIndustrial; } }

        public double Precio { get { return _precio; } }

        public Cocina()
        {
            this._codigo = 0;
            this._precio = 0;
            this._esIndustrial = false;
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public override bool Equals(object obj)
        {
            return obj is Cocina && this==(Cocina)obj;
        }

        public static bool operator ==(Cocina unaCocina, Cocina otraCocina)
        {
            return unaCocina._codigo == otraCocina._codigo;
        }

        public static bool operator !=(Cocina unaCocina, Cocina otraCocina)
        {
            return !(unaCocina == otraCocina);
        }

        public override string ToString()
        {
            return "Cocina | Codigo: " + this._codigo + " - Precio: " + this._precio + " - Es industrial: " + this._esIndustrial + "\n";
        }



    }
}
