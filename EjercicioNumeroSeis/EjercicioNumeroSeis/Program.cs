using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, dolar;
            const int tasa = 50;

            Console.WriteLine("Ingrese cantidad en pesos Dominicanos : ");
            peso = Double.Parse(Console.ReadLine());

            dolar = peso * tasa;

            Console.WriteLine("\n {0:C2} pesos equivale a {1:C2} dolares", peso, dolar);

            Console.ReadLine();

        }
    }
}
