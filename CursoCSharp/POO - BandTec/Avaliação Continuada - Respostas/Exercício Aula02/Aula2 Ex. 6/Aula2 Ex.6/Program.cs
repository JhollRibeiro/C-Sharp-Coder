using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, res, alic;

            Console.WriteLine("Vamos calcular o Valor líquido de seu salário?\nDigite o valor de seu salário:");
            sal = float.Parse(Console.ReadLine());

            if (sal <= 360)
            {
                alic = (sal * 0.08f);
                res = (sal - alic);
                Console.WriteLine("Seu Salário Líquido é: R$ " + res + "\nE a sua Contribuição é: R$ " + alic);
            }

            if ((sal > 360) && (sal < 600))
            {
                alic = (sal * 0.09f);
                res = (sal - alic);
                Console.WriteLine("Seu Salário Líquido é: R$ " + res + "\nE a sua Contribuição é: R$ " + alic);
            }

            if ((sal > 600) && (sal < 1200))
            {
                alic = (sal * 0.11f);
                res = (sal - alic);
                Console.WriteLine("Seu Salário Líquido é: R$ " + res + "\nE a sua Contribuição é: R$ " + alic);
            }

            if (sal > 1200)
            {
                alic = (132);
                res = (sal - 132);
                Console.WriteLine("Seu Salário Líquido é: R$ " + res + "\nE a sua Contribuição é: R$ " + alic);
            }
            Console.ReadKey();
        }
    }
}
