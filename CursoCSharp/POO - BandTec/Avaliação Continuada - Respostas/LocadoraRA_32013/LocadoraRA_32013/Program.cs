using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraRA_32013
{
	class Program
	{
		static void Main(string[] args)
		{
			Fabricante fb1 = new Fabricante(102,"Gorw", "11.222.333/4444-55");
			Fabricante fb2 = new Fabricante(98, "Estrela", "99.888.777/5555-44");

			Categoria cat1 = new Categoria(12, "Jogos de Tabuleiro"); 
			Categoria cat2 = new Categoria(34, "Bonecas");
             
			Produto prd1 = new Produto(23, cat2, fb1, "Boneca Mônica", 100 );
			Produto prd2 = new Produto(78, cat1, fb1, "Colonizadores de Catan", 110);

			Produto prd3 = new Produto(45, cat1, fb2, "Banco Imobiliário", 150);
			Produto prd4 = new Produto(98, cat2, fb2, "Lu Patinadora", 200);


			prd1.exibe();
			prd2.exibe();
			prd3.exibe();
			prd4.exibe();

			Cliente cl1 = new Cliente(56, "João", "333.222.111.00", "44.555.444-3", 1500);
			Cliente cl2 = new Cliente(43, "Poyatos", "777.888.999.55", "66.777.444-x", 2500);

			Venda vd1 = new Venda(1, cl1, prd1);
			Venda vd2 = new Venda(2, cl1, prd4);
			Venda vd3 = new Venda(3, cl2, prd2);
			Venda vd4 = new Venda(4, cl2, prd3);

			vd1.exibe();			
			vd2.exibe();
            prd4.darDesconto(30);
			vd3.exibe();
            prd2.darDesconto(10);
			vd4.exibe();
           
			
			
			Console.ReadKey();			
			
		}
	}
}
