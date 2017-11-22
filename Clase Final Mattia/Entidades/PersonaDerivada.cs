using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades
{
    public class PersonaDerivada:PersonaExterna
    {
        public PersonaDerivada(string n, string a, int e, Entidades.Externa.ESexo s):base(n,a,e,s)
        {

        }

        public string ObtenerInfo()
        {
            return this._nombre + " " + this._apellido + " " + this._edad + " " + this._sexo.ToString();
        }
    }
}
