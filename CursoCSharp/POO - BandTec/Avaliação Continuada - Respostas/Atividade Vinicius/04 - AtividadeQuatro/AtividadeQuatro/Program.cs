using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeQuatro
{
	class Program
	{
		static void Main(string[] args)
		{
			double idade = 0, peso = 0, altura = 0, mediaIdade = 0, mediaAltura = 0, contMais80 = 0;
			int contInf18 = 0;
			for (int contTime = 1; contTime <= 5; contTime++) 
			{

				for (int ContJog = 1; ContJog <= 11; ContJog++) 
				{
					Console.WriteLine("time {0}, jogador{1}", contTime, ContJog);
					Console.WriteLine("Digite a idade");
					idade = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o peso");
					peso = double.Parse(Console.ReadLine());
					Console.WriteLine("digite a altura");
					altura = double.Parse(Console.ReadLine());

					mediaIdade += idade; 
					
					if (idade < 18) 
					{
						contInf18++; 
					}
					if (peso > 80) 
					{
						contMais80++;
					
					}

					mediaAltura += altura;


				}
				mediaIdade /= 11;
				Console.WriteLine("A media de idade do time {0} é {1}", contTime, mediaIdade);
				mediaIdade = 0;
			}

			contMais80 /= 0.55; 
			mediaAltura /= 55;
			Console.WriteLine("existem {0} jogadores com idade inferior a 18 anos", contInf18);
			Console.WriteLine("A média de altur de todos jogadores é {0}", mediaAltura);
		}
	}
}
