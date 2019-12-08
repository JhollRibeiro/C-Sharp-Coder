using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // Conversão implicita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // Conversão explicita
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // Conversão padrão usando o tipo.Parse => 'int.Parse'
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // Conversão padrão usando o Convert.tipo => 'Convert.ToInt32'
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            // Conversão tipo.TryParse => 'int.TryParse' neste caso o C# atribui o valor 0 caso o dado de entrada não seja do tipo 
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            // O mesmo exemplo anterior, porém, otimizado
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
