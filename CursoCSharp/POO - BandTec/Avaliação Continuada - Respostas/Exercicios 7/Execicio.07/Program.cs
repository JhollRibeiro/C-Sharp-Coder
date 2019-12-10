using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente eu = new Cliente(01, "João", "333.444.555.66");
            eu.Exibe();
            
            Cliente outro = new Cliente(02, "Poyatos", "999.888.777.55");  
            outro.Exibe();

            Carro c1 = new Carro(45, "Sedã luxo", "Ford", "Fusion", 10);
            c1.Exibe();

            Carro c2 = new Carro(23, "Hatc Esportivo", "Volksvagen", "Golf", 10);
            c2.Exibe();

            Carro c3 = new Carro(60, "SUV", "Hyundai", "IX35", 10);
            c3.Exibe();

            Locacao l1 = new Locacao(17, eu, c1);
            l1.Exibe();

            Locacao l2 = new Locacao(18, outro, c2);
            l2.Exibe();

            Locacao l3 = new Locacao(19, eu, c3);
            l3.Exibe();

            Locacao l4 = new Locacao(20, outro, c3);
            l4.Exibe();

            Console.ReadKey();
        }
    }
}
