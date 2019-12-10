using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Carro
	{ 
		// Atributos
		
		private string placa;
		private Fabricante fabricante;
		private Motor motor;
		private string modelo;
		private int velocidade;
		private float valorParaLocacao;

		//Contrutores

		public Carro(string placa, Fabricante fabricante, Motor motor, string modelo, float valorParaLocacao) 
		{
			this.placa = placa;
			this.fabricante = fabricante;
			this.motor = motor;
			this.modelo = modelo;
			this.valorParaLocacao = valorParaLocacao;
			this.velocidade = 0;
		}

		//Acessors

		public string Placa
		{
			get { return this.placa; }
			set { this.placa = value; }
		
		}
		public Fabricante Fabricante 
		{
			get { return this.fabricante; }
			set { this.fabricante = value; }
		}
		public Motor Motor 
		{
			get { return this.motor; }
			set { this.motor = value; }
		}
		public string Modelo 
		{
			get { return this.modelo; }
			set { this.modelo = value; }
		}
		public int Velocidade 
		{
			get { return this.velocidade; }
			set { this.velocidade = value; }
		}
		public float ValorParaLocacao 
		{
			get { return this.valorParaLocacao; }
			set { this.valorParaLocacao = value; }
		}

		// métodos/Funções

		public void Exibe() 
		{
			Console.WriteLine("----------------");
			Console.WriteLine("CARRO");
			Console.WriteLine("----------------");
			Console.WriteLine("FABRICANTE: {0}", this.fabricante.Nome);
			Console.WriteLine("CNPJ: {0}", this.fabricante.Cnpj);

			Console.WriteLine("MODELO: {0}", this.modelo);
			Console.WriteLine("PLACA: {0}", this.placa);
			Console.WriteLine("VALOR PARA LOCACAO: R${0}", this.valorParaLocacao);

			Console.WriteLine("POTÊNCIA: {0:f}", this.motor.Potencia);
			Console.WriteLine("COMBUSTÍVEL: {0}", this.motor.TipoCombustivel);

			Console.WriteLine("VELOCIDADE ATUAL: {0}KM/h", this.velocidade);
		}

		public void Acelerar(int acresc_veloc) 
		{
			this.velocidade += acresc_veloc; 
		
		}

		public bool VerificaMotor(Motor m) 
		{

			if (m == this.motor)
			{
				return true;

			}
			else
				return false;
		}
	}
}
