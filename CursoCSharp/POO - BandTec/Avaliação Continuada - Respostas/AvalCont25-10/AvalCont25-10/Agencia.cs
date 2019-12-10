using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
	class Agencia 
	{
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		private Banco banco;

		internal Banco Banco
		{
			get { return banco; }
			set { banco = value; }
		}

		public Agencia(int numero, string nome, Banco banco)
		{
			this.numero = numero;
			this.nome = nome;
			this.Banco = banco;
		}
	}
}
