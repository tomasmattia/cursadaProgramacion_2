using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Uno
{
    class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
        public ConsoleColor color;
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int entero) :this()
        {
            this.entero = entero;
        }
        public Cosa(int entero, string cadena) :this(entero)
        {
            this.cadena = cadena;
        }
        public Cosa(int entero, string cadena,DateTime fecha): this(entero,cadena)
        {
            this.fecha = fecha;
        }
        /// <summary>
        /// Recibe un entero y se le asigna al objeto
        /// </summary>
        /// <param name="entero">Un entero</param>
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        /// <summary>
        /// Recibe una cadena y se le asigna al objeto
        /// </summary>
        /// <param name="cadena">Una cadena</param>
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        /// <summary>
        /// Recibe una fecha y se le asigna al objeto
        /// </summary>
        /// <param name="fecha">Una fecha</param>
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
        /// <summary>
        /// Recibe un color para la consola y se le asigna al objeto
        /// </summary>
        /// <param name="color">Color</param>
        public void EstablecerValor(ConsoleColor color)
        {
            this.color = color;
            Console.ForegroundColor = color;
        }
        /// <summary>
        /// Toma un objeto y retorna una cadena con los valores
        /// </summary>
        /// <returns>Una cadena</returns>
        public string Mostrar()
        {
            return "Valor entero: " + this.entero + "\nvalor cadena: " + this.cadena + "\nfecha: " + this.fecha+ "\nColor: "+this.color;
        }
    }
}
