using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class N_OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++; // incrementa 1 à variavel sem prioridade
            Console.WriteLine(numero1);

            --numero1; // Decrementa 1 da variável com prioridade
            Console.WriteLine(numero1);

            // neste caso antes de incrementar 'numero1' e de comparar o programa vai decrementar 'numero2'
            // logo a execução será: decremnta 'numero2' compara e por fim, incremnta 'numero1'
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
