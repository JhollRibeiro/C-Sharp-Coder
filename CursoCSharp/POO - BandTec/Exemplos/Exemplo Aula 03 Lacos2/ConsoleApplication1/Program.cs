using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			//inicialização da variável
			byte contador = 1;

			//condição de volta
			while (contador <= 10)
			{
				Console.WriteLine(contador);
				//incremento
				contador++; //contador=contador+1;
			}

			// faça .. enquanto
			// do ..while
			contador = 1;
			do
			{
				Console.WriteLine(contador);
				contador++;
			}
			while (contador <= 10);

			for (contador = 1; contador <= 10; contador++)
			{
				Console.WriteLine(contador);
			}



			bool continuaGirando = true;
			while (continuaGirando == true)
			{

				//if()
				continuaGirando = false;
			}

			float nota;
			Console.Write("Digite uma nota de 0 a 10: ");
			nota = float.Parse(Console.ReadLine());
			while ( (nota < 0) || (nota > 10) )
			{
				Console.WriteLine("Nota inválida! Digite novamente");
				Console.Write("Digite uma nota de 0 a 10: ");
				nota = float.Parse(Console.ReadLine());
			}

			float nota2;
			do
			{
				Console.Write("Digite uma nota de 0 a 10: ");
				nota2 = float.Parse(Console.ReadLine());
				if ((nota2 < 0) || (nota2 > 10))
				{
					Console.WriteLine("Nota inválida!");
				}
			}
			while ((nota2 < 0) || (nota2 > 10));




			for(byte x=1; x<=5; x++)
			{
				for (byte y = 1; y <= 2; y++ )
				{
					for (byte z = 1; z <= 10; z++)
					{
						Console.WriteLine("OK");
					}
				}
			}


			while()
			{
				do
				{
					for()
					{
						if()
						{
							for()
							{
							}
						}
					}
				}while();
			}

		}
	}
}
