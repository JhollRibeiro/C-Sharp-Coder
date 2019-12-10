using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
	class Banco
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

		public Banco(int numero, string nome)
		{
			this.numero = numero;
			this.nome = nome;
		}
	}
}
