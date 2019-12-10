using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Program
	{
		static void Main(string[] args)
		{ 
			Carro meuCarro = new Carro("Ferrari", 
									   "Testarosa", 
									   "vermelha", 
									   "BOM-0000");
			meuCarro.locomover();

			meuCarro.Velocidade = 160;

			meuCarro.locomover();

			Aviao meuAviao = new Aviao("Embraer", "Learjet", "branco", "PX-101");
			Console.WriteLine(meuAviao.Modelo);

			meuAviao.Velocidade = 400;
			meuAviao.locomover();



		}
	}
}
