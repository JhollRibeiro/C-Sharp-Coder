using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval.Cont._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float hs, bruto, liquido, mlm = 0, mlf = 0, m = 0, f = 0; char sexo = 'M'; byte i = 0;


            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Qual Sexo do professor " + i + "? Digite M para masculino e F para feminino");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine();

                while (sexo != 'M' && sexo != 'F')
                {
                    Console.WriteLine("Sexo inválido. Digite M para masculino e F para feminino");
                    sexo = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                Console.WriteLine("Digite a quantidade de horas/aula do Professor " + i + ", neste mês.");
                hs = float.Parse(Console.ReadLine());
                Console.WriteLine();

                if (sexo == 'M')
                {
                    m++;
                    bruto = (30 * hs);
                    liquido = (bruto - (30 * hs * 0.1f));
                    mlm = (mlm + liquido);


                    Console.WriteLine("O Salário Bruto do Professor " + i + ", é de R$ " + bruto);
                    Console.WriteLine("O Salário Líquido do Professor " + i + ", é de R$ " + liquido);
                    Console.WriteLine();
                }

                else
                {
                    f++;
                    bruto = (30 * hs);
                    liquido = (bruto - (30 * hs * 0.05f));
                    mlf = (mlf + liquido);
                    Console.WriteLine("O Salário Bruto do Professor " + i + ", é de R$ " + bruto);
                    Console.WriteLine("O Salário Líquido do Professor " + i + ", é de R$ " + liquido);
                    Console.WriteLine();
                }
            }
            f = mlf / f;
            m = mlm / m;

            Console.WriteLine("A média Líquida dos salários dos Professores do sexo Masculino é de : R$ " + m);
            Console.WriteLine();
            Console.WriteLine("A média Líquida dos salários dos Professores do sexo Feminino é de : R$ " + f);

            Console.ReadKey();
        }
    }
}
