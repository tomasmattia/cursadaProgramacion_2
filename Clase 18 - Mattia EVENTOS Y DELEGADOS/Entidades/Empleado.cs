using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelEmp();
    public delegate void ElBoton(Empleado n);
    public delegate void ElReBoton(Empleado n,double crimen);
    public delegate void DelForm(Object n, EmpleadoEventArgs ev);

    public class EmpleadoEventArgs:EventArgs
    {
        public double sueldo;

        public EmpleadoEventArgs(double i)
        {
            this.sueldo = i;
        }
    }

    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private double _sueldo;
        public event DelEmp limiteSueldo;
        public event ElBoton EmpleadoBoton;
        public event ElReBoton EmpleadoReBoton;
        public event DelForm DelegadoForm;

        public string Nombre 
        { 
            get{ return this._nombre; } 
            set{ this._nombre=value; }
        }

        public string Apellido 
        {
            get { return this._apellido; }
            set { this._apellido = value; } 
        }

        public double Sueldo 
        {
            get { return this._sueldo; }
            set
            {
                if (value > 9500)
                {
                    this.limiteSueldo();
                    this.EmpleadoBoton(this);
                    this.EmpleadoReBoton(this,value);
                    this.DelegadoForm(this, new EmpleadoEventArgs(value));
                }
                else
                {
                    if (value > 0)
                    {
                        this._sueldo = value;
                    }
                    else
                    {
                        throw new Exception("Valores menores a 0 ingresar no deben");
                    }
                }
            }
        }

        public override string ToString()
        {
 	         return this._nombre+" "+this.Apellido+" "+this.Sueldo.ToString();
        }

    }
}
