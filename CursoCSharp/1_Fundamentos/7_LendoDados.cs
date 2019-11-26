using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp._1_Fundamentos
{
    class _7_LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            /* 
             * Neste caso o separador de casas decimais utilixado será o padrão do S.O.
             */
            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            /* 
             * Caso queira usar o ponto (.) como separador de casas decimais 
             * deve-se usar o 'CultureInfo.InvariantCulture' 
             * do 'System.Globalization'
            */
            Console.Write("Qual é o seu salário? ");
            salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
