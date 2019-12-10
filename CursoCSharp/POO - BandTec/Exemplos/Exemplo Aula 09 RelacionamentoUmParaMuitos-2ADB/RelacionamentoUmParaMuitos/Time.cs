using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoUmParaMuitos
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
		private byte numeroJogadores;
		public byte NumeroJogadores
		{
			get { return numeroJogadores; }
		}

		//Vetor de jogadores
		private Jogador[] jogadores; //= new Jogador[11];

		public Time(int codigo, string nome)
		{
			this.codigo = codigo;
			this.nome = nome;

			//Criar o vetor
			this.jogadores = new Jogador[11];

			this.numeroJogadores = 0;
		}

		public void AdicionarJogador(Jogador j)
		{
			this.jogadores[this.numeroJogadores] = j;
			this.numeroJogadores++;			
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
				if (j != null)
				{
					Console.WriteLine(j.Nome + " - " + j.Posicao);
				}
			}

		}

		public void RemoverJogador(Jogador j)
		{
			for (byte i = 0; i < this.jogadores.Length; i++)
			{
				if (this.jogadores[i] == j)
				{
					this.jogadores[i] = null;
					this.numeroJogadores--;
					//this.numeroJogadores = this.numeroJogadores - 1;
				}
			}
			
		}



	}
}
