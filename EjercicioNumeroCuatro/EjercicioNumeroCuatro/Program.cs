using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total, cantidad;

            Console.WriteLine("Introduzca la cantidad a llevar : ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el precio unitario : ");
            precio = Convert.ToInt32(Console.ReadLine());

            total = cantidad * precio;

            Console.WriteLine("El total a pagar es : " + total);

            Console.ReadKey();

        }
    }
}
