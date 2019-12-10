using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor = 0, num = 0, num1 = 0, num2 = 0, num3;

            Console.WriteLine("Digite um número");
            menor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            num3 = int.Parse(Console.ReadLine());

            if (menor > num2)
            {
                maior = menor;

                if (maior < num3)
                    maior = num3;
                else
                    if ()






            Console.WriteLine("A ordem decrescente dos números digitados é:\n" + menor + ", " + num + ", " + maior);

            Console.ReadKey();
        }
    }
}
