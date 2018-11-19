using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroSiete
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, superficie;

            Console.WriteLine("Ingrese el valor del lado del cuadrado : ");

            valor = Convert.ToInt32(Console.ReadLine());

            superficie = valor * valor;

            Console.WriteLine(" La superficie del cuadrado es : " + superficie);

            Console.ReadLine();
        }
    }
}
