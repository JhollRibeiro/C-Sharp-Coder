using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] notas = new float[7];

			notas[0] = 5.5f;
			notas[1] = 7.5f;
			notas[2] = 9.5f;

			int num = 6;
			notas[num] = 4.0f;

			notas[num / 2] = 2.0f;

			//percorrer o array

			for (byte indice = 0; indice < 7; indice++)
			{
				Console.WriteLine(notas[indice]);
			}


		}
	}
}
