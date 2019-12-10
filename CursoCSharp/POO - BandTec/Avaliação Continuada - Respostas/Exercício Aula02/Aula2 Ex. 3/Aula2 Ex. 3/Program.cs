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
            float maior = 0, menor = 0, med = 0, num = 0;

            Console.WriteLine("Digite um número");
            num = float.Parse(Console.ReadLine());
            maior = num;
            med = num;
            menor = num;

            if (num > maior)
                maior = num;

            if (num <= menor)
                menor = num;

            else
                med = num;

            Console.WriteLine("Digite um número");
            num = float.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;

            if (num <= menor)
                menor = num;

            else
                med = num;

            Console.WriteLine("Digite um número");
            num = float.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;

            if (num <= menor)
                menor = num;

            else
                med = num;


            Console.WriteLine("A ordem decrescente dos números digitados é:\n" + menor + ", " + med + ", " + maior);
            Console.ReadKey();
        }
    }
}


