using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiaAlberti.Tomas
{
    public class Comercio
    {
        protected string _dueño;
        protected List<Articulo> _misArticulos;
        protected List<Venta> _misVentas;

        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            int flag = 0;
            foreach(Articulo chucheria in this._misArticulos)
            {
                if(chucheria==articuloComprado)
                {
                    chucheria.Stock = chucheria + articuloComprado;
                    flag = 1;
                    break;
                }
            }
            if (flag==0)
            {
                this._misArticulos.Add(articuloComprado);
            }
        }

        public static void MostrarArticulos(Comercio ComercioAMostrar)
        {
            foreach (Articulo chucheria in ComercioAMostrar._misArticulos)
            {
                Console.WriteLine(chucheria.NombreYCodigo);
            }
        }

        public static void MostrarGanancias(Comercio ComercioParaResumen)
        {
            double ganancias = 0;
            foreach(Venta venta in ComercioParaResumen._misVentas)
            {
                ganancias += venta.RetornarGanacia();
            }
            Console.WriteLine("Las ganancias de las ventas fueron de: "+ ganancias);
        }

        public void VenderArticulo(Articulo articuloSolicitado,int cantidad)
        {
            int flag = 0;
            foreach (Articulo chucheria in this._misArticulos)
            {
                flag = 0;
                if (chucheria == articuloSolicitado)
                {
                    flag = 1;
                    if(chucheria.HayStock(cantidad))
                    {
                        chucheria.Stock = chucheria - cantidad;
                        Venta unaVenta = new Venta(articuloSolicitado, cantidad);
                        this._misVentas.Add(unaVenta);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El siguiente producto no tiene stock para la venta");
                        Console.WriteLine(chucheria.NombreYCodigo);
                    }
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("El siguiente producto no existe para la venta");
                Console.WriteLine(articuloSolicitado.NombreYCodigo);
            }

        }
    }
}
