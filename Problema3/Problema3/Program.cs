using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario1, incremento, salario2;

            Console.WriteLine("Introduca el salario anterior: ");

            salario1 = Convert.ToInt32(Console.ReadLine());

            incremento = salario1 * 40 / 100;

            salario2 = salario1 + incremento;

            Console.WriteLine("El nuevo salario es igual a RD$" + salario2);

            Console.ReadLine();
        }
    }
}
