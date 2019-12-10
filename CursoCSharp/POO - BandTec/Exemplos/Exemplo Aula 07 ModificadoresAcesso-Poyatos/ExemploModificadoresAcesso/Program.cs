using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploModificadoresAcesso
{
	class Program
	{
		static void Main(string[] args)
		{
			//Instanciação do Objeto
			Produto prod1 = new Produto();
			prod1.codigo = 1;
			Console.WriteLine(prod1.codigo);
			//prod1.nome = "Água mineral"; // proibido
			//prod1.preco = 1.99f //proibido
			prod1.ativo = true; // pode.é internal
			prod1.SetNome("Água mineral");
			Console.WriteLine(prod1.GetNome());
			prod1.Preco = 1.99f;
			Console.WriteLine(prod1.Preco);

			Produto prod2 = new Produto(2, "Chocolate", 2.99f, true);
			prod2.Exibe();

			prod2.PrecoFormatado = "R$ 1999,99";
			Console.WriteLine(prod2.Preco);
		}
	}
}
