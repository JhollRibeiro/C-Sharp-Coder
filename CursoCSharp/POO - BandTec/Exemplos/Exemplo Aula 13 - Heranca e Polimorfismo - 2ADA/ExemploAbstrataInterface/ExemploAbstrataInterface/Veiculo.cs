using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstrataInterface
{
	abstract class Veiculo
	{
		//Podemos ter atributos e accessors
		//normalmente
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

		public Veiculo(string fabricante, string modelo )
		{
			this.fabricante = fabricante;
			this.modelo = modelo;
		}
		//método abstrato
		public abstract void Buzinar();

		public abstract string DarSeta(string direcao);

		public void TrocarMarcha()
		{
			Console.WriteLine("Veículo trocando de marcha");
		}
	}
}



