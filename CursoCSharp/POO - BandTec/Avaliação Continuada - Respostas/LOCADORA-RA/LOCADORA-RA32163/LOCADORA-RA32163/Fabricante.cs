using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Fabricante
	{
		// Atributos 
		
		private int codigo;
		private string nome;
		private string cnpj;

		//Construtores

		public Fabricante(int codigo, string nome, string cnpj)
		{
			this.codigo = codigo;
			this.nome = nome;
			this.cnpj = cnpj;
		}

		//Acessors

		public int Codigo 
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}
		public string Nome 
		{
			get { return this.nome; }
			set { this.nome = value; }
		}
		public string Cnpj 
		{
			get { return this.cnpj; }
			set { this.cnpj = value; }
		}


	}
}
