using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LocadoraRA_32013
{
	class Categoria
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

		public Categoria(short codigo, string nome) 
		{
			this.codigo = codigo;
			this.nome = nome;
		}
	}
}
