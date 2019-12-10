using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFuncoes
{
	class Program
	{
		static void Main(string[] args)
		{
			//Chamada da Função
			exibeMsg();
			exibeMsg();
			exibeMsg();

			int resultado = soma(2, 2);
			int resultado2 = soma(4, 4);
			int resultado3 = soma(resultado, resultado2);

			Console.WriteLine(resultado3);

			int numero = 4;
			aoQuadrado(ref numero);
			Console.WriteLine(numero);
			
		}

		//Declaração da Função
		static void exibeMsg()
		{
			Console.WriteLine("Alô Mundo!");
		}

		static int soma(int num1, int num2)
		{
			return num1 + num2;
		}

		static void aoQuadrado(ref int num)
		{
			num = (int) Math.Pow(num, 2);
		}
	}
}
