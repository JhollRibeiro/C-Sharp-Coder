using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.F_MetodosEFuncoes
{
    /*
     * Delegate nada mais é do que você definir um TIPO que armazena uma assinatura de uma 
     * função/método.
     * 
     * No exemplo a seguir, "criaremos" do nosso jeito uma Func, veja que uso o tipo Func e sim 
     * o nome do delegate que eu criei, obviamente respeitando os parêmtros e o tipo do retorno.
     */

    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}
