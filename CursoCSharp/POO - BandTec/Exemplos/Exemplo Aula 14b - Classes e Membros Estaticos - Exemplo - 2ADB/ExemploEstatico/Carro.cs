using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstatico
{
	//Classe não estática
	class Carro
	{
		// atributo não estático
		// quando virar objeto, cada um
		// vai ter o seu!
		private string fabricante;

		// accessor não estático
		public string Fabricante
		{
			get { return fabricante; }
			set { fabricante = value; }
		}

		//atributos estáticos
		public static int numeroDeRodas = 4;

		//método estático
		public static void OQueE()
		{
			Console.WriteLine("É um carro!");
		}

		//método não-estático
		public void Locomover()
		{
			Console.WriteLine("O {0} está em movimento", 
				this.fabricante);
		}

		//Pode ter construtor
		public Carro()
		{

		}
	}
}
