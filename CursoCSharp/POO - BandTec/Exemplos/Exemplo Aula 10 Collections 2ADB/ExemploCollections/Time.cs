using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCollections
{
	class Time
	{
		private int codigo;

		public int Codigo 
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private string nome; 

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public int NumeroJogadores
		{
			get { return jogadores.Count; }
		}

		//Collection de jogadores
		private List<Jogador> jogadores = new List<Jogador>();

		public Time(int codigo, string nome)
		{
			this.codigo = codigo;
			this.nome = nome;
		}

		public void AdicionarJogador(Jogador j)
		{
			this.jogadores.Add(j);
		}

		public void Exibe()
		{
			Console.WriteLine("-- ESCALACAO DO TIME --");
			Console.WriteLine(this.Nome);

			/*For automático
			 * percorre do primeiro ao último
			 * a cada volta colocando um jogador
			 * diferente na variável j
			 * USAR SOMENTE PARA SAÍDA
			 */
			
			foreach(Jogador j in this.jogadores)
			{
				Console.WriteLine(j.Nome + " - " + j.Posicao);
			}

		}

		public void RemoverJogador(Jogador j)
		{
			this.jogadores.Remove(j);
		}


	}
}
