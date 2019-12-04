using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class F_NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // a interrogação "?" fará com que propriedade/funcionalidade Lenght seja executada
                                                        // somente se o variavel estiver ok, ou seja inicializada diferente de nula
                                                        // ou seja, a propriedade Lenght só será executada/acessada caso a variável
                                                        // 'valorImportante' não seja nula.

            valorImportante = "";
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
