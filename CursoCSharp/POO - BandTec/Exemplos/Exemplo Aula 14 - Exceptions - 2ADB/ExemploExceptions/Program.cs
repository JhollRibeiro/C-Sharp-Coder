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
			Digite:

			Console.WriteLine("Digite um número divisor: ");

			try
			{
				int divisor = int.Parse(Console.ReadLine());
				if (divisor > 10)
				{
					throw new NaoPodeMaiorQueDezException();
				}
				float total = 10 / divisor;
				Console.WriteLine(total);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Burro, não pode zero!");
				goto Digite;
			}
			catch (FormatException)
			{
				Console.WriteLine("ô idiota, não pode letra!!");
				goto Digite;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Número gigante!");
				goto Digite;
			}
			catch (NaoPodeMaiorQueDezException)
			{
				Console.WriteLine("Não pode um número maior que 10 !");
				goto Digite;
			}
			catch (Exception)
			{
				Console.WriteLine("Erro inesperado!");
				goto Digite;
			}
			finally
			{
				Console.WriteLine("Fim do Programa!");
			}
		}
	}
}
