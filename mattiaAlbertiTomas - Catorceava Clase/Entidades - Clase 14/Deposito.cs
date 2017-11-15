using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class Deposito<T>
        where T:new()
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T obj)
        {
            return this + obj;
        }

        public bool Remover(T obj)
        {
            return this - obj;
        }

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(T unObj)
        {
            int index = 0;
            foreach (T obj in this._lista)
            {
                if (obj.Equals(unObj))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static bool operator -(Deposito<T> elDeposito, T obj)
        {
            if (elDeposito.GetIndice(obj) > -1)
            {
                elDeposito._lista.RemoveAt(elDeposito.GetIndice(obj));
                return true;
            }
            return false;
        }

        public static bool operator +(Deposito<T> elDeposito, T obj)
        {
            if (elDeposito._capacidadMaxima >= elDeposito._lista.Count + 1)
            {
                elDeposito._lista.Add(obj);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string stringRetorno = "";
            stringRetorno += "Capacidad maxima : " + this._capacidadMaxima + "\n";
            stringRetorno += "Listado de "+ typeof(T).Name +":\n";
            foreach (T obj in this._lista)
            {
                stringRetorno += obj.ToString();
            }
            return stringRetorno;
        }
    }
}
