using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			//âncora
			Digite:

			Console.Write("Digite o número divisor: ");

			try
			{
				int divisor = int.Parse(Console.ReadLine());
				if (divisor > 10)
				{
					throw new NaoPodeMaiorQueDezException();
				}

				int total = 10 / divisor;
				Console.WriteLine("Resultado: {0}", total);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Burro, não pode zero!");
				goto Digite;
			}
			catch (FormatException)
			{
				Console.WriteLine("ô imbecil, não pode letra!");
				goto Digite;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Número gigante! não pode!");
				goto Digite;
			}
			catch (NaoPodeMaiorQueDezException)
			{
				Console.WriteLine("Não pode divisor maior que 10!");
				goto Digite;
			}
			catch (Exception)
			{
				Console.WriteLine("Erro inesperado!");
				goto Digite;
			}
			finally
			{
				
			}

			Console.WriteLine("Fim do Programa");

            Console.ReadKey();
			
		}
	}
}
