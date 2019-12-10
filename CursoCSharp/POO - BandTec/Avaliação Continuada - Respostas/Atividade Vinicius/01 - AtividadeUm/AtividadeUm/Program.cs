using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeUm
{
	class Program
	{
		static void Main(string[] args)
		{
			double salario, porc = 0.015;
			salario = 1000.00;
			

			for (int cont = 5; cont <= 13; cont++) 
			{
				if (cont == 5) 
				{
					Console.WriteLine("Voce entrou agora o salario atual é R${0}", salario);
				
				}else
						if (cont == 6)
						{

							salario +=  (salario * porc);
							Console.WriteLine("este é o ano {0} seu salario foi para{1}", cont, salario);
						}
				
						else 
						{
							porc += porc;
							salario += (salario * porc);
							Console.WriteLine("este é o ano {0} seu salario foi para{1}", cont, salario);
						}


				Console.ReadKey();
				
				
					 
			    

			
			}







		}
	}
}
