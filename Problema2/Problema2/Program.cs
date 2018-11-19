using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, pres, vol, temp;

            Console.WriteLine("Introduzca la presion :");
            pres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el volumen : ");
            vol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la temperatura :");
            temp = Convert.ToInt32(Console.ReadLine());

            masa = pres * vol / (0.37 * (temp + 460));

            Console.WriteLine("La masa es igual a :"+ masa);

            Console.ReadKey();
        }
    }
}
