using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO
{
	class ContaBancaria
	{
		//Gets & Sets

		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private Agencia agencia;

		public Agencia Agencia
		{
			get { return agencia; }
			set { agencia = value; }
		}

		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		private float saldo;

		public float Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		protected List<Transacao> transacoes = new List<Transacao>();

		// Construtores

		public ContaBancaria(int numero, Agencia agencia, Cliente cliente, float saldo)
		{
			this.numero = numero;
			this.agencia = agencia;
			this.cliente = cliente;
			this.saldo = saldo;
		}

		// Métodos

		public virtual void VerSaldo()
		{
			Console.WriteLine("Banco: " + this.agencia.Banco.Nome + " (" + this.agencia.Banco.Numero + ")");
			Console.WriteLine("Agencia: " + this.agencia.Numero + " (" + this.agencia.Nome + ")");
			Console.WriteLine("Cliente: " + this.cliente.Nome);
			Console.WriteLine("Saldo atual: " + this.saldo);
		}

		public void VerExtratoSoTransacoes()
		{
			foreach (var item in transacoes)
			{
				Console.WriteLine(item.Data + "   " + item.Tipo + "   " + item.Descricao + "   " + item.Valor);
			}
		}
		
		public virtual void VerExtrato()
		{
			this.VerSaldo();
			Console.WriteLine();
			this.VerExtratoSoTransacoes();
		}

		public void RegistraDeposito(float valor)
		{
			Transacao trans = new Transacao("CREDITO", "Deposito em conta", valor);
			transacoes.Add(trans);
		}

		public bool Depositar(float valor)
		{
			this.saldo = this.saldo + valor;

			this.RegistraDeposito(valor);

			return true;
			
		}

		public virtual bool Sacar(float valor)
		{
			if (this.saldo >= valor)
			{
				this.saldo = this.saldo - valor;
				Transacao trans = new Transacao("DEBITO", "Saque", valor);
				transacoes.Add(trans);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool Transferir(ContaBancaria cD, float valor)
		{
			if (this.Sacar(valor) == true)
			{
				cD.Depositar(valor);
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
