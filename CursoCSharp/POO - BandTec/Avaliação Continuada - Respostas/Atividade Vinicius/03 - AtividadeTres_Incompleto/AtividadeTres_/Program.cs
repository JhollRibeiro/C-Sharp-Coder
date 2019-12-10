using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTres_
{
	class Program
	{
		static void Main(string[] args)
		{
			int codigo, numHorasMes;
			String turnoDeTrabalho = "", categoria = "";
			double salarioMin = 450, valorHora = 0;

			for (int contFunc = 0; contFunc <= 10; contFunc++)
			{

				Console.WriteLine("Digite o codigo");
				codigo = int.Parse(Console.ReadLine());

				Console.WriteLine("Digite a categoria");
				categoria = Console.ReadLine();

				Console.WriteLine("Digite o turno de trabalho");
				turnoDeTrabalho = Console.ReadLine();

				if (categoria == "G" && turnoDeTrabalho == "N")
				{
                   valorHora = salarioMin * 0.18;
				}else
				   if (categoria == "G" && (turnoDeTrabalho == "M" | turnoDeTrabalho == "V"))
				   {
					valorHora = salarioMin * 0.15;
				   }else
					   if (categoria == "O" && turnoDeTrabalho == "N")
					   {
						   valorHora = salarioMin * 0.13;
					   }
					   else
						   if (categoria == "O" && (turnoDeTrabalho == "M" | turnoDeTrabalho == "V"))
						   {
							   valorHora = salarioMin * 0.10;
						   }
						






			}





		}
	}
}
