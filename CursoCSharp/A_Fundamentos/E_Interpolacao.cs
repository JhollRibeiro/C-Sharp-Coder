using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.A_Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            /*
             * A interpolação ocorre quando queremos concatenar uma string com o valor de uma variavel;
             * Usando um indice (0, 1, 3...) entre chaves {} no meio de uma string e
             * na sequencia da string, separadas pos virgulas, as variáveis que substituirão esses indices;
             * Ou ainda,
             * Quando usamos o cifrão ($) imediatamente antes da string e 
             * colocando as variáveis entre chaves {} no meio da string
             */

            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal!");

            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
