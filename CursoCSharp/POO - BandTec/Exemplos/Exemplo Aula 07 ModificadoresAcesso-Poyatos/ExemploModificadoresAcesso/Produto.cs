using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploModificadoresAcesso
{
	class Produto
	{
		//Atributos
		public int codigo; //todo mundo acessa
		private string nome; //só a própria classe
		protected float preco;
		internal bool ativo;

		public Produto()
		{
		}

		public Produto(int codigo, string nome, float preco, bool ativo)
		{
			this.codigo = codigo;
			this.nome = nome;
			this.preco = preco;
			this.ativo = ativo;
		}

		public void Exibe()
		{
			Console.WriteLine(this.nome);
			Console.WriteLine(this.preco);
		}

		//getter do nome
		public string GetNome()
		{
			return this.nome;
		}

		//setter do nome
		public void SetNome(string value)
		{
			this.nome = value;
		}

		//Acessors
		public float Preco
		{
			get { return this.preco; }
			set { this.preco = value; }
		}

		public string PrecoFormatado
		{
			get
			{
				return "R$ "+this.preco;
			}

			set
			{
				this.preco = float.Parse(value.Replace("R$", ""));
			}
		}
		
		


	}
}
