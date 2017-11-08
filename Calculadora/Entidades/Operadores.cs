using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public delegate int OpeDel(string operador,int num1,int num2);
    public class Operadores
    {
        private int num1;
        private int num2;

        public int ElegirOperacion(string operador,int num1, int num2)
        {
            switch (operador)
            {
                case "+":
                    return Suma(num1, num2);
                case "-":
                    return Resta(num1, num2);
                case "*":
                    return Multiplicacion(num1, num2);
                case "/":
                    return Division(num1, num2);
                default:
                    return 0;
            }
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            return 0;
        }

        public bool Guardar(string linea)
        {
            TextWriter escritor = new StreamWriter("operaciones.txt",true);
            escritor.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +" // "+ linea);
            escritor.Close();
            return true;
        }
    }
}
