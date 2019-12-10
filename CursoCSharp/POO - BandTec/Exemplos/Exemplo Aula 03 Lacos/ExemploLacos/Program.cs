using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLacos
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
				contador++; // contador = contador + 1;
			}

			//inicialização da variável
			contador = 1;
			do
			{
				Console.WriteLine(contador);
				//incremento
				contador++; // contador = contador + 1;
				//condição de volta
			} while (contador <= 10);

			for (contador = 1; contador <= 10; contador++)
			{
				Console.WriteLine(contador);
			}


			float nota;
			//Exemplo de validação de entrada
			Console.Write("Digite uma nota de 0 a 10: ");
			nota = float.Parse(Console.ReadLine());
			while ((nota < 0) || (nota > 10))
			{
				Console.Write("Nota inválida! Digite novamente!");
				Console.Write("Digite uma nota de 0 a 10: ");
				nota = float.Parse(Console.ReadLine());
			}


			//Exemplo de validação de entrada
			do
			{
				Console.Write("Digite uma nota de 0 a 10: ");
				nota = float.Parse(Console.ReadLine());
			} while ((nota < 0) || (nota > 10)) ;


			bool girar = true;
			while (girar == true)
			{
				//comandos
				if (1 == 1)
				{
					girar = false;
				}
			}
			
			for(byte x=1; x<=10;x++)
			{
				for (byte y = 1; y <= 3; y++ )
				{
					for (byte z = 1; z <= 2; z++)
					{
						Console.Write("OK!");
					}
				}
			}








			for (contador = 1; contador <= 10; contador++)
			{
				Console.WriteLine(contador);
			}

			//Laço for: deve ser mais utilizado
			//quando for necessário dar voltas
			//conhecidas

		}
	}
}
