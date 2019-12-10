using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float preço = 0, valor = 0;
            byte opçao;

            Console.WriteLine("Qual o preço do produto?");
            preço = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a opção de pagamento:\n1 - À vista em dinheiro ou cheque.\n2 - À vista no Cartão de Crédito.\n3 - Em duas vezes.\n4 - Em três vezes.");
            opçao = byte.Parse(Console.ReadLine());

            switch (opçao)
            {
                case 1: valor = preço - (preço * 0.1f);
                    Console.WriteLine("O Valor a ser pago é: R$ " + valor);
                    break;

                case 2: valor = preço - (preço * 0.05f);
                    Console.WriteLine("O Valor a ser pago é: R$ " + valor);
                    break;

                case 3: valor = preço / 2;
                    Console.WriteLine("O Valor a ser pago é: R$ " + valor + " em Duas Parcelas.");
                    break;

                case 4: valor = (preço + (preço * 0.1f)) / 3;
                    Console.WriteLine("O Valor a ser pago é: R$ " + valor + " em Três Parcelas.");
                    break;

                default: Console.WriteLine("Opção inválida");
                    break;

            }
            Console.ReadKey();

        }
    }
}
