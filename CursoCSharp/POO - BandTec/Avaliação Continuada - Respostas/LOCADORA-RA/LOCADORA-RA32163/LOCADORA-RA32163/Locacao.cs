using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Locacao
	{
		// Atributos
		
		private int codigo; 
		private DateTime data;
		private Cliente cliente;
		private Carro carro;

		// Construtor

		public Locacao(int codigo, Cliente cliente, Carro carro)
		{

			if (cliente.Saldo >= carro.ValorParaLocacao)
			{
				this.codigo = codigo;
				this.cliente = cliente;
				this.carro = carro;
				this.data = DateTime.Now;

				cliente.Saldo -= carro.ValorParaLocacao;
			}
			else 
			{
				Console.WriteLine("Erro não possui saldo suficiente");
			}
		}

		//Acessors

		 public int Codigo
		 {
			set { this.codigo = value; }
			get { return this.codigo; }
		 }
		 public DateTime Data 
		 {
			set { this.data = value; }
			get { return this.data; }
		 }
		 public Cliente Cliente 
		 {
			 set { this.Cliente = value; }
			 get { return this.Cliente; }
		 }
		 public Carro Carro 
		 {
			 set { this.Carro = value;}
			 get { return this.carro; }
		 }
		
		// Métodos 

		public void Exibe() 
		{ 
			Console.WriteLine("----------------");
			Console.WriteLine("LOCACAO");
			Console.WriteLine("----------------");
			Console.WriteLine("CODIGO: {0}", this.codigo);
			Console.WriteLine("DATA DA LOCACAO: {0}", this.data.ToString("dd \\de MMMM \\de yyyy H:mm:ss"));

			Console.WriteLine("CARRO: {0} {1} - {2}", this.carro.Fabricante.Nome, this.carro.Modelo, this.carro.Placa);
			Console.WriteLine("VALOR PARA LOCACAO: R$ {0}", this.carro.ValorParaLocacao);

			Console.WriteLine("CLIENTE: {0}", this.cliente.Nome);
			Console.WriteLine("CPF: {0}", this.cliente.Cpf);
			Console.WriteLine("RG: {0}", this.cliente.Rg);
			Console.WriteLine("SALDO ATUAL: R$ {0}", this.cliente.Saldo);
		}

	}
}
