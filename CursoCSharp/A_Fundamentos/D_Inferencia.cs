using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class D_Inferencia
    {
        public static void Executar()
        {
            /*
             * A inferencia acontece quando o C# detecta o tipo de dado que é atribuido a um objeto do tipo var = implicito
             */

            var nome = "João";
            // nome = 123;
            Console.WriteLine(nome);

            // int idade;
            var idade = 35;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
