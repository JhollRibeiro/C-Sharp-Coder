using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCollections
{
	class Program
	{
		static void Main(string[] args)
		{ 
			// declaração da lista
			List<int> numerosInteiros = new List<int>(); 
			
			// adicionando o número 5
			numerosInteiros.Add(5);

			Console.WriteLine(numerosInteiros[0]);

			numerosInteiros.Insert(0, 10);

			Console.WriteLine(numerosInteiros[0]);
			Console.WriteLine(numerosInteiros[1]);

			numerosInteiros.Add(10);
			numerosInteiros.Add(8);
			numerosInteiros.Add(9);
			numerosInteiros.Add(5);
			numerosInteiros.Add(7);

			Console.WriteLine(numerosInteiros.Count);

			//Apagar todos os elementos
			numerosInteiros.Clear();

			Console.WriteLine(numerosInteiros.Count);

			numerosInteiros.Add(10);
			numerosInteiros.Add(5);
			numerosInteiros.Add(5);
			numerosInteiros.Add(10);
			numerosInteiros.Add(3);
			numerosInteiros.Add(1);
			numerosInteiros.Add(7);
			numerosInteiros.Add(6);
			
			Console.WriteLine("-- Exibindo Coleção --");
			foreach (int num in numerosInteiros)
			{
				Console.WriteLine(num);
			}
			numerosInteiros.RemoveAt(4);
			numerosInteiros.Remove(10);

			Console.WriteLine("-- Exibindo Coleção --");
			foreach (int num in numerosInteiros)
			{
				Console.WriteLine(num);
			}


			List<string> nomes = new List<string>();
			nomes.Add("Fernanda");
			nomes.Add("Clayton");
			nomes.Add("Felipe");
			nomes.Add("Vinicius");

			Console.WriteLine("Buscando pelo Felipe");
			Console.WriteLine(nomes.IndexOf("Felipe"));

			Console.WriteLine("Buscando pelo Zenildo");
			Console.WriteLine(nomes.IndexOf("Zenildo"));

			if (nomes.Contains("Clayton") == true)
			{
				Console.WriteLine("Achei Clayton!");
			}
			else
			{
				Console.WriteLine("Não achei Clayton!");
			}

			nomes.Sort();
			//Exibindo nomes em ordem alfabética
			Console.WriteLine("Exibindo em ordem alfabética");
			foreach (string nome in nomes)
			{
				Console.WriteLine(nome);
			}



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

			oTime.RemoverJogador(oJog1);
			oTime.Exibe();


			//Existem outros tipos de Collections
			//HashSet tem funcionamento similar ao List
			//porém ignora elementos duplicados
			HashSet<int> numeros = new HashSet<int>();
			numeros.Add(10);
			numeros.Add(5);
			numeros.Add(10);

			Console.WriteLine(numeros.Count);

		}
	}
}
