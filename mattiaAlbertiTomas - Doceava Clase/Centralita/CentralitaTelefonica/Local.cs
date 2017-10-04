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
        public override float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this._costo*this._duracion;
        }

        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroOrigen,unaLlamada.TiempoLlamada,unaLlamada.NroDestino,costo)
        {
        }

        public Local(string origen, DateTime tiempoLlamada, string destino, float costo):base(origen,destino,tiempoLlamada)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            return base.Mostrar();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
    }
}
        