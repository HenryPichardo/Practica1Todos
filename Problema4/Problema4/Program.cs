using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesos, dolares, tasa;

            Console.WriteLine("Introduzca la cantidad de pesos: ");

            pesos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la tasa cambiaria: ");

            tasa = Convert.ToInt32(Console.ReadLine());

            dolares = pesos * tasa;

            Console.WriteLine("la cantidad de dolares es us$" + dolares);


            Console.ReadLine();

        }
    }
}
