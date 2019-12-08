using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.F_MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            /*
             * Uma Action nao tem retorno.
             * Pode ser escrita em uma unica sentença de código ou em bloco '{ ... }'.
             * Pode ou não receber parâmetros.
             */

            // Exemplo sem parâmetros e em bloco
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Exemplo Lambda sem parâmetros e em bloco.");
                Console.WriteLine("Lambda com C#!");
            };
            algoNoConsole();

            // Exemplo sem parâmetros e em uma sentença de código
            Action algoNoConsole2 = () => Console.WriteLine("Exemplo Lambda sem parâmetros e em uma " +
                "sentença de código.\nLambda com C#!");
            algoNoConsole2();

            // Exemplo com parâmetros e em bloco
            Action<int, int> actionSomar = (a, b) =>
            {
                Console.WriteLine("Exemplo Lambda com parâmetros e em bloco.");
                Console.WriteLine($"Action Somar = {a + b}");
            };
            actionSomar(2, 4);

            // Exemplo com parâmetros e em uma sentença de código
            Action<int, int> actionSomar2 = (a, b) => Console.WriteLine($"Exemplo Lambda com parâmetros e " +
                $"em bloco.\nAction Somar = {a + b}");
            actionSomar2(8, 4);


            /*
             * Uma Func já espera um retorno.
             * Uma Func tbm aceita parâmetros.
             * O tipo de retorno de uma func é declarado após os parâmetros,
             * caso tenha soemnte um tipo, isso significa que não há parâmetros e que esse é o tipo do retorno.
             * 
             * Veja os exemplos abaixo:
             */
             
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            /*
             * Quando há somente um parêmtros na declaração da Func, 
             * é facultativo o uso de parenteses '()' para os parÊmetros.
             * 
             * Veja os próximos exemplos:
             */
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
