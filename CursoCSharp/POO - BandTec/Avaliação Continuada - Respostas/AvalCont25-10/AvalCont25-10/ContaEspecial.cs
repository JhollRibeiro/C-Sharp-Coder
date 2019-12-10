using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
	class ContaEspecial : ContaBancaria
	{
		private float limite;

		public float Limite
		{
			get { return limite; }
			set { limite = value; }
		}

		public ContaEspecial(int numero, Agencia agencia, Cliente cliente, float saldo, float limite)
			: base(numero, agencia, cliente, saldo)
		{
			this.limite = limite;
		}
	}
}
