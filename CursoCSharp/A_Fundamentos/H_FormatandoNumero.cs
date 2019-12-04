using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class H_FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));   // Formatar usando arredondamento em uma casa decimal
            Console.WriteLine(valor.ToString("C"));    // Formatar para valor monetário 'C' = curency. Obs: Moeda do S.O.
            Console.WriteLine(valor.ToString("P"));    // Formatar para porcentagem 'P' = porcentagem
            Console.WriteLine(valor.ToString("#.##")); // Formatar usando arredondamento em duas casas decimais

            CultureInfo cultura = new CultureInfo("en-US");   // Informações de cultura USA
            Console.WriteLine(valor.ToString("C0", cultura)); // 'C0' = valor monetário sem casas decimais
                                                              // OBS: Por padrão o Curency usa duas casas decimais e as configurações do S.O.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Adiciona Zeros à esquerda até completar 10 casas
                                                        // neste caso adicionará 7 zeros mais o número 256, 
                                                        // logo, 256 contém 3 casas somandas com 7 zeros = 10
        }
    }
}
