using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuatrodeSetembro
{
	class Produto
	{
		//Atributos
		 
		public int codigo;
		public string nome;
		public float preco;
		public string categoria;
		public int qtdeEstoque;
	

		// Métodos Construtores

		public Produto()
		{
		}
		public Produto(int cod, string nome, float preco, string cat)
		{
			this.codigo = cod;
			this.nome = nome;
			this.preco = preco;
			this.categoria = cat;
			this.qtdeEstoque = 100;
		}

		// métodos | funções
		
		public void Exibe() 
		{
			Console.WriteLine("________________________________");
			Console.WriteLine("PRODUTO");

			Console.WriteLine("________________________________");
			Console.WriteLine("Código: {0}", this.codigo);

			Console.WriteLine("Nome: {0}", this.nome);

			Console.WriteLine("Categoria: {0}", this.categoria);

			Console.WriteLine("Preço: {0}", this.preco);

			Console.WriteLine("Quantidade em Estoque: {0}", this.qtdeEstoque);

			Console.WriteLine("________________________________");
		}


	}
}
