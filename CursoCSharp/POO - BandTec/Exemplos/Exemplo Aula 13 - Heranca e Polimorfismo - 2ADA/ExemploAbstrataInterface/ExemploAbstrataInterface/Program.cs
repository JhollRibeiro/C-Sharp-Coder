using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAbstrataInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			//Não dá para instanciar de uma classe abstrata
			//Veiculo meuVeiculo = new Veiculo();

			Carro meuCarro = new Carro("Ford", "Focus");
			meuCarro.Buzinar();
			
		}
	}
}
