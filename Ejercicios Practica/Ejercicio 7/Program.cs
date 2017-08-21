using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";
            int dia;
            int mes;
            int anio;
            int diasTotal=0;
            DateTime localDate = DateTime.Now;

            Console.Write("Ingrese el dia de su nacimiento : ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out dia))
                {
                    Console.Write("error, reingrese el dia: ");
                }
                if (dia > 31 || dia < 1)
                {
                    Console.Write("error, ingrese un dia valido : ");
                }
            } while (dia > 31 || dia < 1);

            Console.Write("Ingrese el mes de su nacimiento : ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out mes))
                {
                    Console.Write("error, reingrese el mes: ");
                }
                if (mes < 1 || mes > 12)
                {
                    Console.Write("error, ingrese un mes valido : ");
                }
            } while (mes < 1 || mes > 12);
            Console.Write("Ingrese el año de su nacimiento : ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out anio))
                {
                    Console.Write("error, reingrese el año: ");
                }
                if (anio < 1900 || anio > localDate.Year)
                {
                    Console.Write("error, ingrese un año valido : ");
                }
            } while (anio < 1900 || anio > localDate.Year);
            if(anio!= localDate.Year)
            {
                diasTotal += diasDesdeComienzo() + diasHastaFinal(dia, mes, anio) + diasPorAnios(anio + 1, localDate.Year - 1);
            }
            else
            {
                if(mes!= localDate.Month)
                {
                    diasTotal += diasHastaFinal(dia, mes, anio) - diasHastaFinal(localDate.Day, localDate.Month, localDate.Year);
                }
                else
                {
                    diasTotal = localDate.Day - dia;
                }
            }
            
            Console.Write("La cantidad de dias es " + diasTotal);
            Console.Read();
        }
        static public int esBisiesto(int anio)
        {
            int returnAux = 0;
            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
            {
                returnAux = 1;
            }
            return returnAux;
        }
        static public int diasDesdeComienzo()
        {
            int diasContados = 0;
            DateTime localDate = DateTime.Now;
            int[] diasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int contador;
            if (localDate.Month == 1)
            {
                diasContados = localDate.Day;
            }
            else
            {
                if (localDate.Month > 1)
                {
                    for (contador = 1; contador < localDate.Month; contador++)
                    {
                        diasContados += diasMeses[contador - 1];
                    }
                    if (localDate.Month >= 2 || (localDate.Month == 2 && localDate.Day == 29))
                    {
                        if (esBisiesto(localDate.Year) == 1)
                        {
                            diasContados += 1;
                        }
                    }
                    diasContados += localDate.Day;
                }

            }
            return diasContados;
        }

        static public int diasHastaFinal(int dia, int mes, int anio)
        {
            int diasContados = 0;
            int[] diasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int contador;
            if (mes == 12)
            {
                diasContados = 31 - dia;
            }
            else
            {
                for (contador = 12; contador >= mes; contador--)
                {
                    diasContados += diasMeses[contador - 1];
                }
                if (mes <= 2 || (mes == 2 && dia == 29))
                {
                    if (esBisiesto(anio) == 1)
                    {
                        diasContados += 1;
                    }
                }
                diasContados -= dia;
            }
            return diasContados;
        }

        static public int diasPorAnios(int anioOrigen, int anioFinal)
        {
            int diasContados = 0;
            int contador;
            for(contador=0;contador<=(anioFinal - anioOrigen);contador++)
            {
                diasContados += 365;
                if (esBisiesto(anioFinal-contador)==1)
                {
                    diasContados += 1;
                }
            }
            return diasContados;
        }
    }
}
