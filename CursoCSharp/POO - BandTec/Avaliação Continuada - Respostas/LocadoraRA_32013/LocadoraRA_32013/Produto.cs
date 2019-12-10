using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraRA_32013
{
	class Produto
	{
		private short codigo;
         
		public short Codigo
		{
			get { return codigo; }
			set { codigo = value; }
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
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		private float preco;

		public float Preco
		{
			get { return preco; }
			set { preco = value; }
		}
		private float precoCusto;

		public float PrecoCusto
		{
			get { return precoCusto; }
			set { precoCusto = value; }
		}

		private int qtde;

		public int Qtde
		{
			get { return qtde; }
			set { qtde = value; }
		}

		public Produto(short codigo, Categoria categoria, Fabricante fabricante, string nome, float precoCusto)
		{

			this.codigo = codigo;
			this.categoria = categoria;
			this.Fabricante = fabricante;
			this.nome = nome;
			this.precoCusto = precoCusto;
			this.preco = precoCusto + (precoCusto * 0.2f);
			this.qtde = 10;
		}


		public void exibe()
		{
			Console.WriteLine("___________________________");
			Console.WriteLine();
			Console.WriteLine("PRODUTO");
			Console.WriteLine("___________________________");
			Console.WriteLine("PRODUTO: {0}", this.nome);
			Console.WriteLine("CATEGORIA: {0}", this.categoria.Nome);
			Console.WriteLine("FABRICANTE: {0}", this.fabricante.Nome);
			Console.WriteLine("CNPJ: {0}", this.fabricante.Cnpj);
			Console.WriteLine("VALOR DE CUSTO: {0}", this.precoCusto);
			Console.WriteLine("VALOR DE VENDA: {0}", this.Preco);
			Console.WriteLine("QUANTIDADE EM ESTOQUE: {0}", this.Qtde);
			Console.WriteLine("___________________________");
			Console.WriteLine();
			Console.WriteLine();

		}
		public void darDesconto(float perc)
		{
            preco = preco - (perc / 100) * preco;

            if (preco < precoCusto)
            {
                Console.WriteLine("ERRRO, o desconto não pode ser aplicado ");
                Console.WriteLine("Preço de venda menor que preço de custo.");
            }
            else
            
                Console.WriteLine("Esse produto pode ser vendido com desconto de {0}%. Valor de venda: {1:C}", perc, this.preco);

            Console.WriteLine();
            Console.WriteLine();
		}

		public bool verificaCategoria(Categoria c)
		{
			if (c == this.categoria)
			{
				return true;

			}
			else
				return false;
		}


	}
}
