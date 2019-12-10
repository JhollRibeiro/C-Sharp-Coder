using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class Cliente
	{
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private string cpf;

		public string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}

		public Cliente(string nome, string cpf)
		{
			this.cpf = cpf;
			this.nome = nome;
		}
		
	}
}
