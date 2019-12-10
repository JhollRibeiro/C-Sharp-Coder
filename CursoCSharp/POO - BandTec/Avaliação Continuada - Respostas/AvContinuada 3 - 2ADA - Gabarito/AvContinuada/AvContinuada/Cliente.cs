using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvContinuada
{
	class Cliente
	{
		public int codigo;
		public string nome; 
		public string cpf;
		
		public Cliente(int codigo, string nome, string cpf) 
		{
			this.codigo = codigo;
			this.nome = nome;
			this.cpf = cpf;
		}
		public Cliente()
		{
	
		}
		public void Exibe()
		{
			Console.WriteLine("CLIENTE--------------");
			Console.WriteLine("Código: " + this.codigo);
			Console.WriteLine("Nome: " + this.nome);
			Console.WriteLine("CPF: " + this.cpf);
			Console.WriteLine("---------------------");
		}


	}
}
