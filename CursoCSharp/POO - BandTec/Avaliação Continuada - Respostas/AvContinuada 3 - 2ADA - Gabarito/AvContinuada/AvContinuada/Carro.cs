using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvContinuada
{
	class Carro
	{
		public int codigo;
		public string marca; 
		public string modelo;
		public string categoria;
		public int qtdeEstoque;

		public Carro(int codigo, string marca, string modelo, string categoria)
		{
			this.codigo = codigo;
			this.marca = marca;
			this.modelo = modelo;
			this.categoria = categoria;
			this.qtdeEstoque = 10;
		}
		public Carro()
		{ 
		}
		public void Exibe()
		{
			Console.WriteLine("CARRO----------------");
			Console.WriteLine("Código: " + this.codigo);
			Console.WriteLine("Categoria: " + this.categoria);
			Console.WriteLine("Marca: " + this.marca);
			Console.WriteLine("Modelo: " + this.modelo);
			Console.WriteLine("Quantidade em Estoque: " + this.qtdeEstoque);
			Console.WriteLine("---------------------");
		}

	}
}
