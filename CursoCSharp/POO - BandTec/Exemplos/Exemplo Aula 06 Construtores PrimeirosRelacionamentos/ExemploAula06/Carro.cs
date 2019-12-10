using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula06
{
	class Carro
	{
		//Atributos
		public int placa;
		public string marca;
		public string modelo;
		public string cor;
		public Proprietario dono; 

		//Método Construtor
		public Carro()
		{
			this.cor = "Azul";
		}

		public Carro(string cor)
		{
			this.cor = cor;
		}

		public Carro(int cod, string mar, string mod, string cor)
		{
			this.placa = cod;
			this.marca = mar;
			this.modelo = mod;
			this.cor = cor;
		}

		
	}

}
