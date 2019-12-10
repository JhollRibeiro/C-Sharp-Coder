using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class ContaPoupanca : ContaBancaria
	{
		private DateTime diaAniversario;

		public DateTime Aniversario
		{
			get { return diaAniversario; }
			set { diaAniversario = value; }
		}

		// Construtor

		public ContaPoupanca(DateTime diaAniversario, int numero, Agencia agencia, Cliente cliente, float saldo)
			: base(numero, agencia, cliente, saldo)
		{
			this.diaAniversario = diaAniversario;
		}

		// Métodos

		public bool RenderJuros(float valor)
		{
			DateTime time = DateTime.Now; // Use current time
			
			if (time.ToString("d") == diaAniversario.ToString())
			{
				Saldo = Saldo * valor;
				Transacao trans = new Transacao("CREDITO", "Rendimento", (Saldo * valor));
				transacoes.Add(trans);
				return true;
			}
			else
			{
				return false;
			}
		}
		
	}
}
