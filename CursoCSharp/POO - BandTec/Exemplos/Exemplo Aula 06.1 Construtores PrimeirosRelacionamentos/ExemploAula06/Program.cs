using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula06
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro meuCarro = new Carro();
			Console.WriteLine(meuCarro.cor);
			meuCarro.cor = "Amarelo"; // posso mudar de cor

			Carro seuCarro = new Carro("Vermelho");
			Console.WriteLine(seuCarro.cor);

			Carro carroDele = new Carro(1, "Volkswagen", "Fusca", "azul bebê");
			Console.WriteLine(carroDele.marca);

			Proprietario aluno = new Proprietario();
			aluno.nome = "João Carlos";
			aluno.rg = "54.432.232-X";

			carroDele.dono = aluno;

			Console.WriteLine(carroDele.dono);
			
		}
	}
}
