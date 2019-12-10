using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula11_2ADA
{
    //Esse é o quarto passo do exemplo recortei os atributos de carro par ca 
    //(fabricante, modelo, cor, velocidade)

    class Veiculo
    {
        private string fabricante;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private int velocidade;

        public int Velocidade // nao entra no construtor pq ele será condicionado
        {
            get { return velocidade; }
            set { velocidade = value; }
        }


        //6 passo
        public Veiculo(string fabricante, string modelo, string cor)
        {
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.cor = cor;
            this.Velocidade = 0; // condiconada (todo carro criado começa com velocidade 0)
        }

        public virtual void locomover() //polimorfismo tem q usar virtual
        {
            Console.Write("O veículo {0} {1} {2} está ", this.fabricante, this.modelo, this.cor);

            if (Velocidade == 0)
            {
                Console.WriteLine("Parado");
            }

            else
            {
                Console.WriteLine("Em movimento");
            }
            Console.WriteLine();
        }
    }
}
