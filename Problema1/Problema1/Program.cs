using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, perimetro;

            Console.WriteLine("Introduzca el valor de uno de los lado de un cuadrado ");
             lado = Convert.ToInt32(Console.ReadLine());

            perimetro = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es : " + perimetro);

            Console.ReadLine();



        }
    }
}
