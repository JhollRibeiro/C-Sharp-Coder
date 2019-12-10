using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula11_2ADA

//Esse é o primeiro passo do exemplo
{
    class Carro : Veiculo
    {
        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
       

        public Carro(string fabricante, string modelo, string cor, string placa) : base(fabricante, modelo, cor)
        {
           
            this.Placa = placa; // não precisa mudar para maisculo pq faz parte dessa classe
          
        }

        public override void locomover() //polimorfismo
        {
            base.locomover();
            Console.WriteLine("É um carro.");
            Console.WriteLine();
        }
    }
}
