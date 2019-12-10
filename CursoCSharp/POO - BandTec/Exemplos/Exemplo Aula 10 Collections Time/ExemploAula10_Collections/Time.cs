using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula10_Collections
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
            get { return this.jogadores.Count; }
		}

		//lista de jogadores
        private HashSet<Jogador> jogadores = new HashSet<Jogador>();

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
            Console.WriteLine();

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
            Console.WriteLine();
            Console.WriteLine();
		}

		public void RemoverJogador(Jogador j)
		{
            this.jogadores.Remove(j);			
		}
	}
}
