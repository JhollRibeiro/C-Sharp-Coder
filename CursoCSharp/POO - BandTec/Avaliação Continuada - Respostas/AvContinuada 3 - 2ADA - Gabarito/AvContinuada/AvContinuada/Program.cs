using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvContinuada
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente eu = new Cliente(1, "Alexandro", "415.554.198.01");
			eu.Exibe();
			Cliente outro = new Cliente(2, "Mario", "999.999.999.99");
			outro.Exibe(); 
			
			//CARRO
			Carro primCarro = new Carro(1, "Fiat", "Uno", "Popular"); 
			primCarro.Exibe();
			Carro segCarro = new Carro(2, "Wolksvagen", "Gol", "Popular");
			segCarro.Exibe();
			Carro terCarro = new Carro(3, "Nissan", "Skyline", "Sport");
			terCarro.Exibe();

			//Locação
			Locacao primLoc = new Locacao(1, eu, primCarro);
			primLoc.Exibe();
			Locacao segLoc = new Locacao(2, outro, segCarro);
			segLoc.Exibe();
			Locacao terLoc = new Locacao(3, eu, terCarro);
			terLoc.Exibe();
			Locacao quarLoc = new Locacao(4, outro, terCarro);
			quarLoc.Exibe();
			Console.ReadKey();
		}
	}
}
