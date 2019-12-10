using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
	class Transacao
	{
		private int codigo;

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

		public Transacao(int codigo, string tipo, DateTime data, string descricao, float valor)
		{
			this.codigo = codigo;
			this.tipo = tipo;
			this.data = data;
			this.descricao = descricao;
			this.valor = valor;
		}
	}
}
