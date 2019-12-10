using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraRA_32013
{
	class Cliente 
	{
		private short codigo;

		public short Codigo
		{
			get { return codigo; } 
			set { codigo = value; }
		}
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
		private string rg;

		public string Rg
		{
			get { return rg; }
			set { rg = value; }
		}
		private float saldo;

		public float Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public Cliente(short codigo, string nome, string cpf, string rg, float saldo)
		{
			this.codigo = codigo;
			this.nome = nome;
			this.cpf = cpf;
			this.rg = rg;
			this.saldo = saldo;
		}



	}
}
