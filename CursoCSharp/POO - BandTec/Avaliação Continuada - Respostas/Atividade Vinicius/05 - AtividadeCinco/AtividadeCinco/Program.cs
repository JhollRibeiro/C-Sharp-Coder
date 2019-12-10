using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCinco
{
	class Program
	{
		static void Main(string[] args)
		{

			double soma = 0, quantidade = 0, media = 0, menor = 0, mediaPares = 0, leitor = 1, maior = 0, quantPares = 0;

			do
			{

				Console.WriteLine("Manda numeros");
				leitor = double.Parse(Console.ReadLine());

				soma += leitor;
				quantidade++;
				media += leitor;

				if (quantidade == 1) 
				{
					maior = leitor;
					menor = leitor;
				}
				if (leitor < menor) 
				{

					menor = leitor;
				}
				if (leitor > maior)
				{

					maior = leitor;
				}
				if (leitor % 2 == 0) 
				{
					quantPares++;
					mediaPares += leitor; 
				
				}


			} while (leitor != 0);
			
			media /= quantidade;
			mediaPares /= quantPares; 

			Console.WriteLine("A soma é: {0}", soma);
			Console.WriteLine("A quantidade dos numeros digitados é: {0}", quantidade);
			Console.WriteLine("A media dos numeros digitados é: {0}", media);
			Console.WriteLine("O maior numero é: {0}", maior);
			Console.WriteLine("O menor numero é: {0}", menor);
			Console.WriteLine("A media dos pares é {0}", mediaPares);


			Console.ReadKey();

		}
	}
}
