using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Carro : Veiculo
	{
		private string placa;

		public string Placa
		{ 
			get { return placa; }
			set { placa = value; }
		}

		public Carro(string fabricante, 
					 string modelo, 
					 string cor, 
					 string placa): base(fabricante, modelo, cor)
		{
			this.placa = placa;
		}

		public override void locomover()
		{
			if (this.Velocidade == 0)
			{
				Console.WriteLine("O carro {0} {1} está parado!",
								this.Fabricante,
								this.Modelo);
			}
			else
			{
				Console.WriteLine("O carro {0} {1} está rodando a {2} km/h.",
								this.Fabricante,
								this.Modelo,
								this.Velocidade);
			}
		}
	}
}
