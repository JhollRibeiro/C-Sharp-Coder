using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuatrodeSetembro
{
	class Program
	{
		static void Main(string[] args)
		{ 
			
			
			Cliente euAluno = new Cliente(1, "Vinicius Garcia", "49.368.XXX.X");
			Cliente outroCliente = new Cliente(2, "José Carlos", "48.868.XXX.X");

			euAluno.Exibe();
			outroCliente.Exibe();

			Produto produtoUM = new Produto(135247, "TV LG 55 3D", 2999.00f, "Eletrônicos");
			Produto produtoDois = new Produto(874854, "Blueray Sony", 650.00f, "Eletrônicos"); ;
			Produto produtoTres = new Produto(542102, "Geladeira Brastemp FF", 3999.00f, "Eletrodomésticos");

			produtoUM.Exibe();
			produtoDois.Exibe();
			produtoTres.Exibe();

			Compra primeiraCompra = new Compra(1, euAluno, produtoUM);
			Compra segundaCompra = new Compra(2, outroCliente, produtoDois);
			Compra terceiraCompra = new Compra(3, euAluno, produtoTres);
			Compra quartaCompra = new Compra(4, outroCliente, produtoTres);

			primeiraCompra.Exibe();
			segundaCompra.Exibe();
			terceiraCompra.Exibe();
			quartaCompra.Exibe();

			Console.ReadKey();
		}
	}
}
