using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente aluno = new Cliente(1, "João", "333.888.555.22");
            aluno.Exibe();
            Console.WriteLine();

			Cliente meuCliente = new Cliente(2, "Poyatos", "555.444.888.11");
			meuCliente.Exibe();
            Console.WriteLine();

			Carro carro1 = new Carro(1, "Passeio", "GM","Vectra", 10);
            carro1.Exibe();
            Console.WriteLine();

            Carro carro2 = new Carro(2, "SW", "Volksvagen", "Toureg", 10);
            carro1.Exibe();
            Console.WriteLine();

            Carro carro3 = new Carro(3, "Pick-up", "Volksvagen", "Saveiro", 10);
            carro1.Exibe();
            Console.WriteLine();

            Locacao Loc1 = new Locacao(1, aluno, carro1);
            Loc1.Exibe();

            Locacao Loc2 = new Locacao(2, meuCliente, carro2);
            Loc2.Exibe();

            Locacao Loc3 = new Locacao(3, aluno, carro3);
            Loc3.Exibe();
            Locacao Loc4 = new Locacao(4, meuCliente, carro3);
            Loc4.Exibe();

			Console.ReadKey();
		}
	}
}
