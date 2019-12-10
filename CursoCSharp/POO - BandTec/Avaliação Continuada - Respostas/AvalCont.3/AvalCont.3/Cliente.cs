using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont._3
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
            Console.WriteLine("__________________________");
            Console.WriteLine();
            Console.WriteLine("CLIENTE: "+codigo);
            Console.WriteLine("__________________________");
            Console.WriteLine();
			Console.WriteLine("NOME: "+nome);
			Console.WriteLine("CPF: "+cpf);
            Console.WriteLine("__________________________");

		}
	}
}
