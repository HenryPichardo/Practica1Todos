using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioNumeroCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, mult, divi;

            Console.WriteLine("Ingrese el primer valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer valor: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto valor: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            mult = num3 + num4;
            divi = num1 + num4;

            Console.WriteLine("La suma del primero y el segundo es igual a : " + suma);
            Console.WriteLine("La multiplicacion del tercero y el cuarto es igual a: " + mult);
            Console.WriteLine("La division del primero y el cuarto es igual a: " + divi);
            
            Console.ReadLine();
        }
    }
}
