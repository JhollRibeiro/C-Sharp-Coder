using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunArr._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3, b = 3, c = 3;

            determinarTriangulo(a, b, c);

            determinarTriangulo(a = 3, b = 4, c = 5);

            determinarTriangulo(a = 3, b = 3, c = 5);
        

            Console.ReadKey();
        }
        static void determinarTriangulo(float a, float b, float c)
        {
            if (a == b && b == c)
                Console.WriteLine("Equilátero");
            else if ((a == b && b != c) || (b == c && b != a) || (a == c && a != c))
                Console.WriteLine("Isósceles");
            else if (a != b && b != c)
                Console.WriteLine("Escaleno");

        }
    }
}
