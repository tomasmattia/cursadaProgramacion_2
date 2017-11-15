using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto unAuto)
        {
            return this + unAuto;
        }

        public bool Remover(Auto unAuto)
        {
            return this - unAuto;
        }

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Auto unAuto)
        {
            int index=0;
            foreach (Auto auto in this._lista)
            {
                if (auto.Equals(unAuto))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static bool operator -(DepositoDeAutos elDeposito, Auto unAuto)
        {
            if (elDeposito.GetIndice(unAuto) > -1)
            {
                elDeposito._lista.RemoveAt(elDeposito.GetIndice(unAuto));
                return true;
            }
            return false;
        }

        public static bool operator +(DepositoDeAutos elDeposito, Auto unAuto)
        {
            if (elDeposito._capacidadMaxima >= elDeposito._lista.Count + 1)
            {
                elDeposito._lista.Add(unAuto);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string stringRetorno = "";
            stringRetorno += "Capacidad maxima: " + this._capacidadMaxima+"\n";
            stringRetorno += "Listado de Autos:\n";
            foreach (Auto auto in this._lista)
            {
                stringRetorno += auto.ToString();
            }
            return stringRetorno;
        }

    }
}
