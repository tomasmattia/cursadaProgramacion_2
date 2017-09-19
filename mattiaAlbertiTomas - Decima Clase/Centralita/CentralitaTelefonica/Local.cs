using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    public class Local:Llamada
    {
        protected float _costo;
        public float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this.CostoLlamada*base.Duracion;
        }

        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        public new string Mostrar()
        {
            return base.Mostrar()+"/ Costo :"+this.CostoLlamada;
        }
    }
}
        