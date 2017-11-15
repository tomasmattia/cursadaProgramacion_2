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
            if (this.Capacidad != 0)
            {
                return this + obj;
            }
            else
            {
                throw new DepositoLlenoException();
            }
        }

        public bool Remover(T obj)
        {
            return this - obj;
        }

        public List<T> Lista { get { return this._lista; } }

        public int Capacidad { get { return this._capacidadMaxima - this._lista.Count; } }

        public Deposito(int capacidad):this()
        {
            try
            {
                if (capacidad > 50)
                {
                    this._capacidadMaxima = 50;
                    throw new Exception("Mucho");
                }
                else if (capacidad < 1)
                {
                    this._capacidadMaxima = 1;
                    throw new Exception("Poco");
                }
                else
                {
                    this._capacidadMaxima = capacidad;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private Deposito()
        {
            this._lista = new List<T>();
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
            try
            {
                if (elDeposito._capacidadMaxima >= elDeposito._lista.Count + 1 && elDeposito._lista.Count + 1 < 50)
                {
                    elDeposito._lista.Add(obj);
                    return true;
                }
                else
                {
                    if (elDeposito._lista.Count + 1 > 50)
                    {
                        throw new DepositoLlenoException();
                    }
                }
            }
            catch (DepositoLlenoException e)
            {
                Console.WriteLine(e.Message);
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
