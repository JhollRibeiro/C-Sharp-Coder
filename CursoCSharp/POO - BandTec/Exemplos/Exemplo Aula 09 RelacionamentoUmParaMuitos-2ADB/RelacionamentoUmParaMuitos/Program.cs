using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoUmParaMuitos
{
	class Program
	{
		static void Main(string[] args)
		{ 
			//Instanciando um objeto jogador 
			Jogador oJog1 = new Jogador(1, "Allejo", 18, "atacante");

			Time oTime = new Time(1, "Seleção Brasileira");
			oTime.AdicionarJogador(oJog1);
			Console.WriteLine(oTime.NumeroJogadores);

			Jogador oJog2 = new Jogador(2, "Gomez", 20, "atacante");
			oTime.AdicionarJogador(oJog2);

			Jogador oJog3 = new Jogador(3, "Tafarell", 21, "goleiro");
			oTime.AdicionarJogador(oJog3);
			
			Console.WriteLine(oTime.NumeroJogadores);

			oTime.Exibe();

			oTime.RemoverJogador(oJog3);
			oTime.Exibe();

            Console.ReadKey();

		}
	}
}
