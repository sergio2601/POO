using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("introduce un numero: ");
            a = Console.Read();

            Console.Write("introduce un numero: ");
            b = Console.Read();

            c = a + b;

            Console.WriteLine("la suma de los numeros introducidos es: " + c);
            Console.ReadKey();
        }
    }
}
