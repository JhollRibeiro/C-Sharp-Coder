using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraRA_32013
{
	class Venda
	{
		private short codigo;

		public short Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
         
		private DateTime data; 

		public DateTime Data
		{
			get { return data; }
			set { data = value; }
		}
		private Cliente cliente;

		internal Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}
		private Produto produto;

		internal Produto Produto
		{
			get { return produto; }
			set { produto = value; }
		}
		private Categoria categoria;

		internal Categoria Categoria
		{
			get { return categoria; }
			set { categoria = value; }
		}
		private Fabricante fabricante;

		internal Fabricante Fabricante
		{
			get { return fabricante; }
			set { fabricante = value; }
		}




		public Venda(short codigo, Cliente cliente, Produto produto)
		{
			this.codigo = codigo;
			this.data = DateTime.Now;
			this.cliente = cliente;
			this.produto = produto;
			this.produto.Qtde--;
			
			
		}

		public void exibe()
		{
			Console.WriteLine("___________________________");
			Console.WriteLine();
			Console.WriteLine("VENDA");
			Console.WriteLine("___________________________");
			Console.WriteLine();
            Console.WriteLine("CÓDIGO: {0}",this.codigo);
			Console.WriteLine("DATA: {0}",this.data);
            Console.WriteLine("NOME DO PRODUTO: {0}", this.produto.Nome);
			Console.WriteLine("CATEGORIA: {0}",this.produto.Categoria.Nome);
			Console.WriteLine("FABRICANTE: {0}", this.produto.Fabricante.Nome);
			Console.WriteLine("CNPJ: {0}", this.produto.Fabricante.Cnpj);
			Console.WriteLine("VALOR DO CUSTO: {0:C}",this.Produto.PrecoCusto);
			Console.WriteLine("VALOR DA VENDA: {0:C}", this.Produto.Preco);
			Console.WriteLine("QUANTIDADE EM ESTOQUE: {0}", this.Produto.Qtde);
			Console.WriteLine();
			Console.WriteLine("CLIENTE: {0}", this.cliente.Nome);
			Console.WriteLine("CPF: {0}", this.cliente.Cpf);
			Console.WriteLine("RG: {0}", this.cliente.Rg);
			Console.WriteLine("___________________________");
			Console.WriteLine();
			Console.WriteLine();

		}
	}
}
