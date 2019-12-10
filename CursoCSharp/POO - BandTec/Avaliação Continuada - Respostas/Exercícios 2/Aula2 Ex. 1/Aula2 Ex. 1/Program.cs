using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            Console.WriteLine("Digite a sua idade.");
            idade = byte.Parse(Console.ReadLine());

            if (idade < 18)
                Console.WriteLine("Ainda Menor!");

            else
                Console.WriteLine("Já Maior!");

            Console.ReadKey();
        }
    }
}
