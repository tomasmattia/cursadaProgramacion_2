using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Alumno:Persona
    {
        private int legajo;

        public int Legajo { get { return legajo; } set { this.legajo = value; } }

        public Alumno():base()
        {
        }

        public Alumno(int legajo,string nombre, string apellido):base(nombre,apellido)
        {
            this.legajo = legajo;
        }
    }
}
