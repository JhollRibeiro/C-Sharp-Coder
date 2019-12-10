using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Calculadora1
{
	class Program
	{
		static void Main(string[] args)
		{
			float num1=0, num2=0,resposta=0;
			byte opção=0;
			 

			Console.WriteLine("Vamos calcular dois números?");
            Console.WriteLine();

			Console.Write("Digite o primeiro número: ");
			num1 = float.Parse(Console.ReadLine());

			Console.Write("Digite o segundo número:");
			num2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

			Console.WriteLine("Escolha a Operação: \n1 - Para soma. \n2 - Para Subtração. \n3 - Para Multiplicação. \n4 - Para Divisão");
			opção = byte.Parse(Console.ReadLine());
            

			switch (opção) 
			{
				case 1: resposta = num1 + num2;
				break;
				case 2: resposta = num1 - num2;
				break;
				case 3: resposta = num1 * num2;
				break;
				case 4: resposta = num1 / num2;
				break;
				default: Console.WriteLine("Opção inválida");
				break;
                				
			}
            Console.WriteLine();
            Console.WriteLine(resposta);
			Console.ReadLine();
		}
	}
}
