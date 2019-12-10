using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaQuatrodeSetembro
{
	class Cliente
	{
		//Atributos
		 
		public int codigo;
		public string nome;
		public string rg;

		// Métodos Construtores
		
		public Cliente() 
		{ 
		}
		
		public Cliente(int cod, string nome, string rg) 
		{
			this.codigo = cod;
			this.nome = nome;
			this.rg = rg;
		}

		// métodos | funções

		public void Exibe() 
		{

			Console.WriteLine("________________________________");
			Console.WriteLine("CLIENTE");

			Console.WriteLine("________________________________");
			Console.WriteLine("Código: {0}", this.codigo);

			Console.WriteLine("Nome: {0}", this.nome);

			Console.WriteLine("RG: {0}", this.rg);

			Console.WriteLine("________________________________");
		}
	}
}
