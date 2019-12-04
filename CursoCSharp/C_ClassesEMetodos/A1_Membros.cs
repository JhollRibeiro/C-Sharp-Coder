using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    class A1_Membros
    {
        public static void Executar()
        {
            A2_Pessoa sicrano = new A2_Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new A2_Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
