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

        public string Mostrar()
        {
            return "Duracion: " + this.Duracion + " / Destino: " + this.NroDestino + " / Origen: " + this.NroOrigen;
        }

        static public int OrdenarPorDuracion(Llamada uno, Llamada dos)
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

    }
}
