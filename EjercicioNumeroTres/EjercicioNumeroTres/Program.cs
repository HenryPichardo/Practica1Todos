using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int ht;
            float costohora, sueldo;
            string linea;

            Console.WriteLine("Introduzca la cantidad de horas trabajadas : ");
            linea = Console.ReadLine();
            ht = int.Parse(linea);

            Console.WriteLine("Introduzca el pago por hora :");
            linea = Console.ReadLine();
            costohora = int.Parse(linea);
            sueldo = ht * costohora;

            Console.WriteLine("el sueldo total es : " + sueldo);

            Console.ReadLine();
        }
    }
}
