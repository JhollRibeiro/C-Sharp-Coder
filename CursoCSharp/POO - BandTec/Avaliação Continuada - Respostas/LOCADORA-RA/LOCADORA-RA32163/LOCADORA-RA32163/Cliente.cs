using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Cliente
	{
         
		// Atributos

		private int codigo;
		private string nome;
		private string cpf;
		private string rg;
		private float saldo;

		// Construtor

		public Cliente(int codigo, string nome, string cpf, string rg, float saldo) 
		{
			this.codigo = codigo;
			this.nome = nome;
			this.cpf = cpf;
			this.rg = rg;
			this.saldo = saldo;
		}

		//Acessors

		public int Codigo
		{
			get {return this.codigo;}
			set { this.codigo = value; }
		}
		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}
		public string Cpf
		{
			get { return this.cpf; }
			set { this.cpf = value; }
		}
		public string Rg
		{
			get { return this.rg; }
			set { this.rg = value; }
		}
		public float Saldo
		{
			get { return this.saldo; }
			set { this.saldo = value; }
		}

	}

}
