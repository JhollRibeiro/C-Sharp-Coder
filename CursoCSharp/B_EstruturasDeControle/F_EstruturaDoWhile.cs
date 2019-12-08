using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.B_EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            // A principal diferença entre o 'While' e o 'Do While' é que o 
            // bloco 'Do While' será executado pelo menos uma vez.
            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
