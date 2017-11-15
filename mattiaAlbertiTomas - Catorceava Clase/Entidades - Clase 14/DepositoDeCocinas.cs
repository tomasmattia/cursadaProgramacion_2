using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public bool Agregar(Cocina unaCocina)
        {
            return this + unaCocina;
        }

        public bool Remover(Cocina unaCocina)
        {
            return this - unaCocina;
        }

        private int GetIndice(Cocina unaCocina)
        {
            int index = 0;
            foreach (Cocina cocina in this._lista)
            {
                if (cocina.Equals(unaCocina))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static bool operator +(DepositoDeCocinas unDeposito, Cocina unaCocina)
        {
            if (unDeposito._capacidadMaxima >= unDeposito._lista.Count+1)
            {
                unDeposito._lista.Add(unaCocina);
                return true;
            }
            return false;
        }

        public static bool operator -(DepositoDeCocinas unDeposito, Cocina unaCocina)
        {
            if (unDeposito.GetIndice(unaCocina) > -1)
            {
                unDeposito._lista.RemoveAt(unDeposito.GetIndice(unaCocina));
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string stringRetorno = "";
            stringRetorno += "Capacidad Maxima: " + this._capacidadMaxima+"\n";
            stringRetorno += "Lista de cocinas: \n";
            foreach (Cocina cocina in this._lista)
            {
                stringRetorno += cocina.ToString();
            }
            return stringRetorno;
        }
        
    }
}
