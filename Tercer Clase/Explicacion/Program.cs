using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Miembros de clase  -> 'static' -> Clase.Miembro
            // Miembros de instancia -> NO static -> objeto.Miembro
            // Private (por defecto)
            // Clase obj;
            // Tipo de todos los tipos -> Object (NADA MAS ALLA DE ESTO)
            // Tipos por valor o tipos referencia
            // POR VALOR  : int, float, bolean,
            // Si estan definidos como atributos en una clase y NO ESTAN EN UN METODO
            // se inicializan con valores por defecto en 0 si son numericos
            // si es boleano se inicializa en false
            // Se define todo en el stack
            // POR REFERENCIA : string, object, 
            // Por defecto son NULL 
            // Hace falta inicializarlas, los datos con los que se inicializan se guardan en el HEAP
            // Constructor sin parametros es el constructor por defecto
            // El constructor puede estar implicito o explicito
            // El nombre del constructor debe tener el nombre de la clase respetando mayusculas y minusculas
            // El new no se puede usar solo, el constructor tampoco
            // Reserva la cantidad necesaria en el HEAP para almacenar todos los elementos que necesite la clase
            // El constructor inicializa todos los atributos de la clase
            
            // Uso de CONVENCIONES

            // Marca -> atributos
            // unaVariable -> variables
            // CONST -> constantes
            // this.Atributo -> de donde viene el atributo

            // crear 1 auto asd456/fiat/150000
            // crear 1 auto qwe789/ford/80000
            Auto primerAuto = new Auto();
            Auto segundoAuto = new Auto();
            primerAuto.Marca = "Fiat";
            primerAuto.Patente = "ASD456";
            primerAuto.Precio = 150000;
            segundoAuto.Marca = "Ford";
            segundoAuto.Patente = "QWE789";
            segundoAuto.Precio = 80000;
            // primerAuto = segundoAuto;
            // TIENEN QUE SER DEL MISMO TIPO SINO HAY QUE CASTEAR
            // O EL CASTEO IMPLICITO
            Console.WriteLine(Auto.mostrarAuto(primerAuto));
            Console.WriteLine(Auto.mostrarAuto(segundoAuto));
            Console.WriteLine(Auto.CantidadInstancias);
            Console.WriteLine(Auto.primero);
            Console.WriteLine(Auto.ultimo);
            Console.WriteLine(Auto.diferencia);
            Console.Read();
        }
    }
}
