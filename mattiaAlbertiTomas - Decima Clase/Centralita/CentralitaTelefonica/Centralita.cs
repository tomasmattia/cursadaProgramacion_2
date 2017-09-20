using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal 
        {
            get { return CalcularGanancias(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial 
        {
            get { return CalcularGanancias(TipoLlamada.Provincial); }
        }

        public float GananciaPorTotal
        {
            get { return CalcularGanancias(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas 
        { 
            get{ return this._listaDeLlamadas; } 
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float calculoGananciasLocal =0;
            float calculoGananciasProvincial = 0;
            foreach (Llamada unaLlamada in this.Llamadas)
            {
                if (unaLlamada is Local)
                {
                    calculoGananciasLocal += ((Local)unaLlamada).CostoLlamada;
                }
                else
                {
                    if (unaLlamada is Provincial)
                    {
                        calculoGananciasProvincial += ((Provincial)unaLlamada).CostoLlamada;
                    }
                }
            }
            switch (tipo)
            {
                case TipoLlamada.Local:
                    return calculoGananciasLocal;
                case TipoLlamada.Provincial:
                    return calculoGananciasProvincial;
                case TipoLlamada.Todas:
                    return calculoGananciasLocal + calculoGananciasProvincial;
            }
            return 0;
        }

        public Centralita()
        {
            this._listaDeLlamadas=new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            string retorno="Razon Social: " + this._razonSocial+" / Ganancia Total: "+this.GananciaPorTotal+" / Ganancia Local: "+this.GananciaPorLocal+" / Ganancia Provincial: "+this.GananciaPorProvincial;
            foreach (Llamada unaLlamada in this.Llamadas)
            {
                retorno += unaLlamada.ToString();
            }
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada unaLlamada)
        {
            this._listaDeLlamadas.Add(unaLlamada);
        }

        public static bool operator ==(Centralita unaCentralita, Llamada unaLlamada)
        {
            foreach (Llamada llamadasCentral in unaCentralita.Llamadas)
            {
                if (llamadasCentral == unaLlamada)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita unaCentralita, Llamada unaLlamada)
        {
            return !(unaCentralita == unaLlamada);
        }

        public static Centralita operator +(Centralita unaCentralita, Llamada unaLlamada)
        {
            if (unaCentralita != unaLlamada)
            {
                unaCentralita.AgregarLlamada(unaLlamada);
            }
            return unaCentralita;
        }
    }
}
