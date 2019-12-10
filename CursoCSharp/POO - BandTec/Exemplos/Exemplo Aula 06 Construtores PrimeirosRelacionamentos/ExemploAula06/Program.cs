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
			//Instanciação do Objeto
			Carro meuCarro = new Carro();
			Console.WriteLine(meuCarro.cor);
			meuCarro.cor = "Amarelo";
			Console.WriteLine(meuCarro.cor);

			Carro seuCarro = new Carro("Vermelho");
			Console.WriteLine(seuCarro.cor);

			Carro meuNovoCarro = new Carro(1, "Ferrari", "Testarosa", "Vermelha");
			Console.WriteLine(meuNovoCarro.marca);
			Console.WriteLine(meuNovoCarro.placa);

			Carro carro1 = new Carro();
			carro1.marca = "Ferrari";
	
			Proprietario eu = new Proprietario();
			eu.nome = "Henrique";
			eu.rg = "12.345.678-X";
			carro1.dono = eu;
	
			// Mostrando meu rg
			Console.WriteLine(carro1.dono.rg);

			// Forma diferente
			meuNovoCarro.dono = new Proprietario();


		}
	}
}
