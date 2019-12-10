using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval.Cont._1
{
	class Program
	{
		static void Main(string[] args)
		{
			float sal = 1000, reaj = 1.5f;
			sal = (sal + (sal * 0.015f));

			for (byte i = 0; i < 7; i++)
				reaj = (reaj * 2);
			sal = (sal + (sal * (reaj / 100)));

				Console.Write("O Salário atual é de : R$ "+sal);
			Console.ReadKey();
		}
	}
}
