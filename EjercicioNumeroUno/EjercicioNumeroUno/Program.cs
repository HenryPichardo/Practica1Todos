using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroUno
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, ciudad;

            Console.WriteLine("Escriba su nombre : ☺");
            nombre = Console.ReadLine();

            Console.WriteLine("Escriba el nombre de una ciudad: ☻");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " Bienvenido a " + ciudad);

            Console.ReadLine();


        }
    }
}
