using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraRA_32013
{
	class Fabricante
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
		private string cnpj;

		public string Cnpj
		{
			get { return cnpj; }
			set { cnpj = value; }
		}

		public Fabricante(short codigo, string nome, string cnpj)
		{
			this.codigo = codigo;
			this.nome = nome;
			this.cnpj = cnpj;
		}
	}
	
}
