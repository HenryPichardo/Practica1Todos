using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, mult;
            string valor;

            Console.WriteLine("Introduzca el primer numero : ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);

            Console.WriteLine("Introduzca el segundo numero : ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);

            suma = num1 + num2;
            mult = num1 * num2;

            Console.WriteLine("La suma de los dos numeros es : " + suma);

            Console.WriteLine("La multiplicacion  de los dos numeros es : " + mult);

            Console.ReadLine();

        }
    }
}
