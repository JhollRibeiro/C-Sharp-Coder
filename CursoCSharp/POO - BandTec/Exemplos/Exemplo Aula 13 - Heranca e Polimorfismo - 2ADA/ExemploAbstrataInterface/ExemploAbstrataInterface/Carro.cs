using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstrataInterface
{
	class Carro : Veiculo, IMovel, IEletrico
	{
		public Carro(string fabricante, string modelo) : base(fabricante, modelo)
		{

		}

		public override void Buzinar()
		{
			Console.WriteLine("Carro buzinando!");
		}

		public override string DarSeta(string direcao)
		{
			return "Carro virou à " + direcao;
		}

		public void Acelerar()
		{
			throw new NotImplementedException();
		}

		public void Frear()
		{
			throw new NotImplementedException();
		}

		public void Ligar()
		{
			throw new NotImplementedException();
		}

		public void Desligar()
		{
			throw new NotImplementedException();
		}
	}
}
