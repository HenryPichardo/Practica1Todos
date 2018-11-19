using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ph, pm, totalh, totalm, totalgeneral;

            Console.WriteLine("Introduzca la cantidad de hombres:");
            totalh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad de mujeres :");
            totalm = Convert.ToInt32(Console.ReadLine());

            totalgeneral = totalh + totalm;

            ph = totalh * 100 / totalgeneral;

            pm = totalm * 100 / totalgeneral;

            Console.WriteLine("El porcentaje de hombres es " + ph + "%");
            Console.WriteLine("El porcentaje de mujeres es " + pm + "%");

            Console.ReadKey();


        }
    }
}
