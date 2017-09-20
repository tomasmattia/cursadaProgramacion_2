using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    public class Llamada    
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get { return Duracion; }
        }

        public string NroDestino
        {
            get { return NroDestino; }
        }

        public string NroOrigen
        {
            get { return NroOrigen; }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        protected virtual string Mostrar()
        {
            return "Duracion: " + this.Duracion + " / Destino: " + this.NroDestino + " / Origen: " + this.NroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            if (uno.Duracion > dos.Duracion)
            {
                return 1;
            }
            else 
            {
                if(uno.Duracion<dos.Duracion)
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
