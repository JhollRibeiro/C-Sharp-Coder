using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosCondicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaração da Variável
			float media;

			//Solicitar a Digitação do usuário
			Console.WriteLine("Digite a Média: ");
			media = float.Parse(Console.ReadLine());

			//Exibir na Tela
			Console.WriteLine("Média : " + media);

			//Condicional Composta
			if (media >= 6) 
			{
				Console.WriteLine("Aprovado");
			}
			else
			{
				if (media >= 4)
				{
					Console.WriteLine("Exame");
				}
				else
				{
					Console.WriteLine("Reprovado");
				}
			}
			
			//switch
			Console.Write("Digite um número");
			byte numero = byte.Parse(Console.ReadLine());
			switch (numero)
			{
				case 1:
				case 3:
					Console.WriteLine("Ímpar");
					break;
				case 2:
				case 4:
				Console.WriteLine("Par");
				break;
			}















			//"Mutreta" para segurar o console
			Console.ReadKey();
		}
	}
}
