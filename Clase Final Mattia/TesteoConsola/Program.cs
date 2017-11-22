using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using Entidades.Externa;
using Entidades;

namespace TesteoConsola
{
    static class Program
    {
        static void Main(string[] args)
        {
            PersonaExternaSellada p3 =new PersonaExternaSellada("Raul", "Lopez", 34, Entidades.Externa.Sellada.ESexo.Masculino);
            PersonaDerivada p2 = new PersonaDerivada("Jorge", "Rodriguez", 50, Entidades.Externa.ESexo.Masculino);
            Persona p1 = new Persona("Juan", "Perez", "22", ESexo.Masculino);
            Console.WriteLine(p1.ObtenerInfo());
            Console.WriteLine(p2.ObtenerInfo());
            Console.WriteLine(p3.Apellido.CantidadCaracteres());
            Console.WriteLine(p3.ObtenerInfo(true));      
            Console.ReadKey();
        }
        static string ObtenerInfo(this PersonaExternaSellada p)
        {
            return p.Nombre + " " + p.Apellido + " " + p.Edad + " " + p.Sexo.ToString();
        }
        static int CantidadCaracteres(this String s)
        {
            return s.Length;
        }

        static string ObtenerInfo(this PersonaExternaSellada p, bool valor)
        {
            if (valor)
            {
                return p.ObtenerInfo().ToUpper();
            }
            else
            {
                return p.ObtenerInfo().ToLower();
            }
        }
    }

}
