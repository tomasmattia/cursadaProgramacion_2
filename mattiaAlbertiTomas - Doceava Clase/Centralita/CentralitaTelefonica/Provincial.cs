using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;
        public override float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            switch (_franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)0.99 * this._duracion;
                case Franja.Franja_2:
                    return (float)1.25 * this._duracion;
                case Franja.Franja_3:
                    return (float)0.66 * this._duracion;
            }
            return 0;
        }

        public Provincial(Franja miFranja,Llamada unaLlamada):this(unaLlamada.NroOrigen,miFranja,unaLlamada.TiempoLlamada,unaLlamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, DateTime tiempoLlamada, string destino)
            : base(origen, destino, tiempoLlamada)
        {
            this._franjaHoraria = miFranja;              
        }

        protected override string Mostrar()
        {
            return base.Mostrar()+" / Franja Horaria: "+this._franjaHoraria.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
    }
}
