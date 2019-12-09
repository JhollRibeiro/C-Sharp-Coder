using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.I_TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            /* 
             * Para atribuir o valor nulo à uma varialvel que tem um valor padrão, como 
             * por exempo o tipo int, o valor padrão é '0' (zero),
             * ou boolean que o valor padrão é 'false'
             * 
             * Use as seguintes expressões:
             */
            Nullable<int> num1 = null;
            int? num2 = null;

            /* Caso não utilizar as expressões acima, vc receberá um erro.
             * Vejo o exemplo abaixo:
             */
            // int num = null;


            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");
            }

            /*
             * Ao atribuir um valor de um nullable em uma variável não nullable
             * vc receberá um erro, pois os tipos são diferentes.
             * 
             * Para isso use '??' que caso o nullable não tenha sido iniciado,
             * a variável não nullabe assumirá o valor padrão customizado passado,  que neste caso é 1000.
             */
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                /*
                 * CUIDADO: Ao trabalahr com nullables garanta sempre que em operações ou algo semalhante
                 * esta variável tenha um valor válido atribuido.
                 * 
                 * Veja o Exempo abaixo: mesmo usando uma navegação segura atravez do '.Value' ele retornará 
                 * o valor nulo.
                 * Neste caso vc pode usar o '??' e atribuir um valor padrão customizado ou
                 * '.GetValueOrDefault()' que assumira o valor padrão do C#, no caso 0 (zero).
                 */

                //int x = num1.Value;
                //int y = num2.Value;
                int x = num1.GetValueOrDefault();
                int y = num2 ?? 2;

                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
