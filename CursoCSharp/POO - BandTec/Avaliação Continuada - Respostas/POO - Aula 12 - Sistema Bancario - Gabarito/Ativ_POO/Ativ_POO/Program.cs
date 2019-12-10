using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class Program
	{
		static void Main(string[] args)
		{
			Banco banc1 = new Banco(1, "Bradesco");
			Agencia age1 = new Agencia(1, "Paulo Zingg", banc1);
			Cliente cli1 = new Cliente("Diego", "427.433.638-78");

			ContaEspecial conEsp = new ContaEspecial(1, age1, cli1, 1000.00f, 1000.00f);
			ContaPoupanca conPop = new ContaPoupanca(DateTime.Now, 1, age1, cli1, 1000.00f);

			conEsp.Depositar(100.00f);
			conEsp.Sacar(50.00f);
			conEsp.Transferir(conPop, 50.00f);

			conPop.RenderJuros(0.10f);

			conEsp.VerExtrato();
			Console.WriteLine();

			conPop.VerExtrato();
			Console.ReadKey();
		}
	}
}
