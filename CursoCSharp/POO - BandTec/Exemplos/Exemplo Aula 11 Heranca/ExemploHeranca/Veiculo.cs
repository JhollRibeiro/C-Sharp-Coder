using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Veiculo
	{
		private string fabricante;

		public string Fabricante
		{
			get { return fabricante; }
			set { fabricante = value; } 
		}

		private string modelo;

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		private string cor;

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}

		private short velocidade;

		public short Velocidade
		{
			get { return velocidade; }
			set { velocidade = value; }
		}

		public Veiculo(string fab, string mod, string cor)
		{
			this.fabricante = fab;
			this.modelo = mod;
			this.cor = cor;
			this.velocidade = 0;
		}

		public Veiculo()
		{

		}
		// "virtual": este método abaixo PODE SER SOBREESCRITO
		public virtual void locomover()
		{
			if (this.Velocidade == 0)
			{
				Console.WriteLine("O veículo {0} {1} está parado!",
								this.Fabricante,
								this.Modelo);
			}
			else
			{
				Console.WriteLine("O veículo {0} {1} está em movimento.",
								this.Fabricante,
								this.Modelo);
			}
		}
	} // fecha classe
} // fecha namespace
