using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCADORA_RA32163
{
	class Motor
	{
		//Atributos
		
		private int codigo; 
		private float potencia;
		private string tipoCombustivel;

		//Construtores

		public Motor(int codigo, float potencia, string tipoCombustivel) 
		{
			this.codigo = codigo;
			this.potencia = potencia;
			this.tipoCombustivel = tipoCombustivel;
		}

		//Acessors

		public int Codigo 
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}
		public float Potencia 
		{
			get { return this.potencia; }
			set { this.potencia = value;}
		}
		public string TipoCombustivel 
		{
			get { return this.tipoCombustivel; }
			set { this.tipoCombustivel = value; }
		}

	}
}
