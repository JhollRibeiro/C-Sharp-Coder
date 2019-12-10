using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoUmParaMuitos
{
	class Jogador
	{ 
		//Atributos
		private int codigo;
		//Accessor
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

		private byte idade;

		public byte Idade
		{
			get { return idade; }
			set { idade = value; }
		}

		private string posicao;

		public string Posicao
		{
			get { return posicao; }
			set { posicao = value; }
		}

		//Construtor
		public Jogador(int codigo, string nome, 
					   byte idade, string posicao)
		{
			this.codigo = codigo;
			this.nome = nome;
			this.idade = idade;
			this.posicao = posicao;
		}

	}
}
