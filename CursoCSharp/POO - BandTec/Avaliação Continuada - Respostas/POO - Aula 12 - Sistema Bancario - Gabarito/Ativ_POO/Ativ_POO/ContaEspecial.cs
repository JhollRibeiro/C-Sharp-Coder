using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class ContaEspecial : ContaBancaria
	{
		private float limite;
				
		public float Limite
		{
			get { return limite; }
			set { limite = value; }
		}

		// Contrutor

		public ContaEspecial(int numero, Agencia agencia, Cliente cliente, float saldo, float limite) 
			: base (numero, agencia, cliente, saldo)
		{
			this.limite = limite;
		}

		// Métodos

		public override bool Sacar(float valor)
		{
			if ((Saldo + Limite) >= valor)
			{
				Saldo = Saldo - valor;

				base.RegistraDeposito(valor);

				return true;
			}
			else
			{
				return false;
			}
		}

		public override void VerSaldo()
		{
			base.VerSaldo();
			Console.WriteLine("Limite: " + this.Limite);
			Console.WriteLine("Saldo Total: " + (Saldo + this.Limite));
		}

		public override void VerExtrato()
		{
			this.VerSaldo();
			base.VerExtratoSoTransacoes();
		}
		
	}
}
