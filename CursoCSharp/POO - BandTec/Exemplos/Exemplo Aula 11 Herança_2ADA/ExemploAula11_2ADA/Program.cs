using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula11_2ADA
{
    class Program
    {
        static void Main(string[] args)
        {    // esse é o segundo passo do exemplo
            Carro meuCarro = new Carro("Ferrari", "Testarossa", "Vermelha", "BOM-0000");
            meuCarro.locomover();

            meuCarro.Velocidade = 160;

            meuCarro.locomover();


            // 5 passo
            Aviao meuAviao = new Aviao("Embraer", "Larjet", "Branco", "FPX - 100");
            meuAviao.Velocidade = 400;
            meuAviao.locomover();

            Console.ReadKey();
        }
    }
}
