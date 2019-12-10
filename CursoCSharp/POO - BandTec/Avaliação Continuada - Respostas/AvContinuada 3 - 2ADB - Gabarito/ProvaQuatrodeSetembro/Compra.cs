using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuatrodeSetembro
{
	class Compra
	{
		//Atributos
		 
		public int codigo;
		public string data;
		public Cliente comprador;
		public Produto produto;

		// Métodos Construtores

		public Compra() 
		{ 
		}
		public Compra(int cod, Cliente comp, Produto prod) 
		{
			this.codigo = cod;
			this.comprador = comp;
			this.produto = prod;
			this.data = DateTime.Now(); // melhor do que this.data = "04/09/2013";
			this.produto.qtdeEstoque -= 1;
		}

		// métodos | funções

		public void Exibe() 
		{
			Console.WriteLine("________________________________");
			Console.WriteLine("COMPRA");

			Console.WriteLine("________________________________");
			Console.WriteLine("Código: {0}", this.codigo);

			Console.WriteLine("Data: {0}", this.data);

			Console.WriteLine("Cliente: {0} - {1}", this.comprador.nome, this.comprador.rg);

			Console.WriteLine("Produto: {0} - {1}", this.produto.nome, this.produto.codigo);

			Console.WriteLine("________________________________");
		
		
		
		}




	}
}
