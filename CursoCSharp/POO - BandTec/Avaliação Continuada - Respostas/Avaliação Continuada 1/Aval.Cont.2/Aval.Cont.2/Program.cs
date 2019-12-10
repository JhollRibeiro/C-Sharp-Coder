using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval.Cont._2
{
	class Program
	{
		static void Main(string[] args)
		{
			float div = 0, p3 = 10, p6 = 15, p9 = 20, p12 = 25;

			Console.WriteLine("Digite o Valor de sua Dívida:");
			div = float.Parse(Console.ReadLine());

			p3 = div + (div * 0.1f);
			p6 = div + (div * 0.15f);
			p9 = div + (div * 0.2f);
			p12 = div + (div * 0.25f);

			Console.WriteLine();
            Console.WriteLine("Valor da Divida: R$ " + div + ". Valor do Juros: 0. Quantidade Parcelas: 1. Valor da Parcela: R$ " +div);
			Console.WriteLine();
            Console.WriteLine("Valor da Divida: R$ " + p3 + ". Valor do Juros: R$ "+(div *0.1)+". Quantidade Parcelas: 3. Valor da Parcela: R$ " +(p3/3));
			Console.WriteLine();
            Console.WriteLine("Valor da Divida: R$ " + p6 + ". Valor do Juros: R$ " + (div * 0.15) + ". Quantidade Parcelas: 6. Valor da Parcela: R$ " + (p6 / 6));
			Console.WriteLine();
            Console.WriteLine("Valor da Divida: R$ " + p9 + ". Valor do Juros: R$ " + (div * 0.2) + ". Quantidade Parcelas: 9. Valor da Parcela: R$ " + (p9 / 9));
			Console.WriteLine();
            Console.WriteLine("Valor da Divida: R$ " + p12 + ". Valor do Juros: R$ " + (div * 0.25) + ". Quantidade Parcelas: 12. Valor da Parcela: R$ " + (p12 / 12));

			Console.ReadKey();
		}
	}
}
