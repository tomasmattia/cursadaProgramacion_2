using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase06;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] otroVec = new int[2, 3];  
            //int[] vec = new int[3];
            //otroVec[1,0] = 2;
            //otroVec[0,1] = 3;
            //otroVec[1,1] = 2;
            //otroVec[0,2] = 3;
            //otroVec[1,2] = 2;
            //otroVec[0,0] = 3;
            //foreach (int i in otroVec)
            //{
            //    Console.WriteLine(i);
            //}
            //double cant= 24;
            //Tempera unaTempera = new Tempera(ConsoleColor.Cyan,"Maped",20);
            //Tempera dosTempera = new Tempera(ConsoleColor.Cyan, "Maped", 52);
            //Tempera tresTempera = new Tempera(ConsoleColor.Magenta, "Peped", 12);
            //Console.WriteLine(unaTempera==tresTempera);
            //Console.WriteLine(tresTempera+200);
            //Console.WriteLine(Tempera.Mostrar(unaTempera));
            Paleta unaPaleta = 1 ;
            Paleta dosPaleta = 3;
            Paleta tresPaleta;
            Tempera unaTempera = new Tempera(ConsoleColor.Cyan, "Maped", 20);
            Tempera dosTempera = new Tempera(ConsoleColor.Cyan, "Kapped", 20);
            unaPaleta += unaTempera;
            dosPaleta += unaTempera;
            dosPaleta += dosTempera;
            tresPaleta= unaPaleta+ dosPaleta;
            Console.WriteLine((string)tresPaleta);
            Console.Read();
        }
    }
}
