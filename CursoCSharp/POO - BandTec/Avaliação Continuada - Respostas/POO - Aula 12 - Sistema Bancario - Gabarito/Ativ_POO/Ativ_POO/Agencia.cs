using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
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

		public Banco Banco
		{
			get { return banco; }
			set { banco = value; }
		}

		public Agencia(int numero, string nome, Banco banco)
		{
			this.Banco = banco;
			this.nome = nome;
			this.numero = numero;
		}
		
	}
}
