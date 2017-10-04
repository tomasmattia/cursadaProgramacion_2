using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    public abstract class Llamada    
    {
        protected float _duracion;
        protected DateTime _tiempoLlamada;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            set { this._duracion=value; }
        }

        public abstract float CostoLlamada{ get; }

        public DateTime TiempoLlamada
        {
            get { return _tiempoLlamada; }
        }

       /* public float Duracion
        {
            get { return _duracion; }
        }*/

        public string NroDestino
        {
            get { return _nroDestino; }
        }

        public string NroOrigen
        {
            get { return _nroOrigen; }
        }

        public Llamada(string origen, string destino, DateTime tiempoLLamada)
        {
            //this._duracion = duracion;
            this._tiempoLlamada = tiempoLLamada;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        protected virtual string Mostrar()
        {
            return "Tiempo inicio: " + this.TiempoLlamada + " / Origen: " + this.NroOrigen + " / Destino: " + this.NroDestino;
        }

        /*protected virtual string Mostrar()
        {
            return "Duracion: " + this.Duracion + " / Origen: " + this.NroOrigen + " / Destino: " + this.NroDestino;
        }*/

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            if (uno._duracion > dos._duracion)
            {
                return 1;
            }
            else 
            {
                if (uno._duracion < dos._duracion)
                {
                    return -1;
                }
                return 0;
            }
        }

        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            return llamadaUno._nroOrigen == llamadaDos._nroOrigen && llamadaUno._nroDestino == llamadaDos._nroDestino && llamadaUno.Equals(llamadaDos);
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

    }
}
