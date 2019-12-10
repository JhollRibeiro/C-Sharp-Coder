using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDois
{
	class Program
	{
		static void Main(string[] args)
		{
			String nomeDaCidade, nomeMenor = "", nomeMaior = "";
			double numVeiPass, numAcidVit, indiceMaior = 0, indiceMenor = 0, mediaCarros = 0, mediaAcid = 0;
			


			for (int contCid = 0; contCid < 5; contCid++) 
			{

				
				
					Console.WriteLine("Nome da cidade {0}", contCid);
					nomeDaCidade = Console.ReadLine();

					Console.WriteLine("Numero de veiculos de passeio (em 2013).");
					numVeiPass = double.Parse(Console.ReadLine());

					Console.WriteLine("Numero de acidentes de transito com vitimas (em 2013).");
					numAcidVit = double.Parse(Console.ReadLine());

					mediaCarros += numVeiPass;

					if (numVeiPass < 2000) 
					{

						mediaAcid += numAcidVit;
					
					
					}

					if (contCid == 0)
					{
						indiceMaior = numAcidVit / numVeiPass;
						nomeMenor = nomeDaCidade;
						indiceMenor = numAcidVit / numVeiPass;
						nomeMaior = nomeDaCidade;

					}
					else
					{
						if ((numAcidVit / numVeiPass) > indiceMaior)
						{
							indiceMaior = numAcidVit / numVeiPass;
							nomeMaior = nomeDaCidade;
						}
						if ((numAcidVit / numVeiPass) < indiceMenor)
						{
							indiceMenor = numAcidVit / numVeiPass;
							nomeMenor = nomeDaCidade;
						}
					}
					
				
			
			
			}
			
			mediaCarros /= 5;
			mediaAcid /= 5;
			
			Console.WriteLine("A Cidade com maior indice é {0} com o seguinte indice: {1}", nomeMaior, indiceMaior);
			Console.WriteLine("A Cidade com menor indice é {0} com o seguinte indice: {1}", nomeMenor, indiceMenor);
			Console.WriteLine("O numero de veiculos de passeio é " +mediaCarros);
			Console.WriteLine("A média de acidentes de transito em cidades com menos de 2000 habitantes é "+ mediaAcid);
			Console.ReadKey();



		}
	}
}
