using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula11_2ADA
{
    //Esse é o terceiro passo do exemplo

    class Aviao : Veiculo
    {
        private string prefixo;

        public string Prefixo
        {
            get { return prefixo; }
            set { prefixo = value; }
        }

        public Aviao(string fabricante, string modelo, string cor, string prefixo) : base(fabricante, modelo, cor)
        {
            this.prefixo = prefixo;
        }


        public override void locomover()//polimorfismo tem q por overrride
        {
            Console.Write("O Avião {0} {1} {2} está ", this.Fabricante, this.Modelo, this.Cor);

            if (Velocidade == 0)
            {
                Console.WriteLine("Parado no Hangar.");
            }

            else
            {
                Console.WriteLine("Voaondo a {0} km/h",this.Velocidade);
            }
        }
    }
}
