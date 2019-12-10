using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class Transacao
	{
		private int codigo = 0;

		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private DateTime data;

		public DateTime Data
		{
			get { return data; }
			set { data = value; }
		}

		private string descricao;

		public string Descricao
		{
			get { return descricao; }
			set { descricao = value; }
		}

		private float valor;

		public float Valor
		{
			get { return valor; }
			set { valor = value; }
		}

		public Transacao(string tipo, string descricao, float valor)
		{
			this.codigo++;
			this.data = DateTime.Now;
			this.tipo = tipo;
			this.descricao = descricao;
			this.valor = valor;
		}
		
		
		
	}
}
