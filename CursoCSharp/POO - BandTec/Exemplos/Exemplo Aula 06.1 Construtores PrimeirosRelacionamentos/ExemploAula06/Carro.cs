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

		//Segundo Construtor - sobrecarga de método
		public Carro(string cor)
		{
			this.cor = cor;
		}

		public Carro(int placa, string marca, string modelo, string cor)
		{
			this.placa = placa;
			this.marca = marca;
			this.modelo = modelo;
			this.cor = cor;
		}

	}
}
