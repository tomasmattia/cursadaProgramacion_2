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
        public float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            switch (_franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)0.99 * base.Duracion;
                case Franja.Franja_2:
                    return (float)1.25 * base.Duracion;
                case Franja.Franja_3:
                    return (float)0.66 * base.Duracion;
            }
            return 0;
        }

        public Provincial(Franja miFranja,Llamada unaLlamada):this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;              
        }

        protected override string Mostrar()
        {
            return base.Mostrar()+" / Franja Horaria: "+this._franjaHoraria.ToString()+"/ Costo :"+this.CostoLlamada;
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
