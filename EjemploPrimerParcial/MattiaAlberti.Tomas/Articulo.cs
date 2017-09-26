using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiaAlberti.Tomas
{
    public class Articulo  
    {
        protected int _codigo;
        protected string _nombre;
        protected float _precioCosto;
        protected float _precioVenta;
        protected int _stock;

        public string NombreYCodigo
        {
            get { return "Nombre: " + this._nombre + " Codigo: " + this._codigo; }
        }

        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = value * ((float)1.3);
            }
        }

        public float PrecioVenta
        {
            get { return this._precioVenta; }
        }

        public int Stock
        {
            set { this._stock=value; }
        }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this.PrecioCosto = precioCosto;
            this.Stock = cantidad;
        }

        public bool HayStock(int cantidad)
        {
            if(this._stock>=cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            return articuloUno.NombreYCodigo == articuloDos.NombreYCodigo;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno.NombreYCodigo == articuloDos.NombreYCodigo);
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            return articuloUno._stock + articuloDos._stock;
        }

        public static int operator -(Articulo articuloUno, int cantidad)
        {
            return  articuloUno._stock - cantidad;
        }
    }
}
