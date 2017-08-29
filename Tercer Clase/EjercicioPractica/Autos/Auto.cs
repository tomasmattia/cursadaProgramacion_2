using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    enum eFabricante { Ford, Chevrolet, Honda };
    class Auto
    {
        eFabricante fabricante;
        string ruedaDD;
        string ruedaDI;
        string ruedaTD;
        string ruedaTI;
        Random modeloFabricante = new Random();

        static Auto()
        {

        }
        public Auto()
        {
            this.fabricante=eFabricante[modeloFabricante.Next(1, 4)];
        }
    }
}
