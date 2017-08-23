using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    class Auto
    {
        // atributos: static -> clase / no static -> instancias
        // metodos: static / no static
        // constructores: instancia -> no static / clase -> no static
        // constructores static: no llevan modificadores de visibilidad, no reciben parametros 
        // Usan static, llevan el mismo nombre de la clase
        // inicializan los atributos static, solo se ejecuta una vez por proyecto coincide con el constructor de instancia
        // 
        public string Marca;
        public string Patente;
        public float Precio;
        static public int CantidadInstancias;
        static public DateTime primero;
        static public DateTime ultimo;
        static public TimeSpan diferencia;
        private string mostrar()
        {
            return "Marca: " + this.Marca + " Patente : " + this.Patente + " Precio : " + this.Precio;
        }
        public static string mostrarAuto(Auto unAuto)
        {
            return unAuto.mostrar();
        }

        static Auto()
        {
            Auto.primero = DateTime.Now;
        }

        public Auto()
        {
            Auto.ultimo = DateTime.Now;
            Auto.CantidadInstancias++;
            Auto.diferencia = Auto.ultimo - Auto.primero;
        }

    }
}
