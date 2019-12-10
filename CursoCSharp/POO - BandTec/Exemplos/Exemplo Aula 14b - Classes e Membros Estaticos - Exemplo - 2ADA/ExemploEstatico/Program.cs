using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstatico
{
	class Program
	{
		static void Main(string[] args)
		{
			//chamado do atributo estático
			Console.WriteLine(Carro.numeroDeRodas);

			//chamada do método estático
			Carro.OQueE();

			//Carro não é estático, logo pode virar objeto!
			Carro meuCarro = new Carro();
			meuCarro.Fabricante = "Fiat";
			meuCarro.Locomover();

			/* O Locomover é um método dinâmico
			 * pois seu resultado varia de instância
			 * para instância, de objeto para objeto
			*/
			Carro seuCarro = new Carro();
			seuCarro.Fabricante = "Gurgel";
			seuCarro.Locomover();
		}
	}
}
