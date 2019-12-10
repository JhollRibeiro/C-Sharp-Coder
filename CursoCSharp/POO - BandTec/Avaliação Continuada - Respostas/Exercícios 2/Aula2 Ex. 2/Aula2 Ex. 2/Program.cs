using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota = 0, nota1 = 0, media;

            Console.WriteLine("Vamos Caulcular a Média?");

            for (byte cont = 1; cont < 5; cont++)
            {
                Console.WriteLine("Digite a Nota Semestral");
                nota = float.Parse(Console.ReadLine());

                while (nota < 0 || nota > 10)
                {
                    Console.WriteLine("ERRO, nota inválida. \nDigite novamente:");
                    nota = float.Parse(Console.ReadLine());
                }
                nota1 = nota1 + nota;
            }

            media = (nota1 / 4);

            if (media >= 7)
                Console.WriteLine("Média " + media + "\nAluno Aprovado, parabéns!");
            else
                Console.WriteLine("Média " + media + "\nAluno Reprovado, estude mais!");

            Console.ReadKey();
        }
    }
}
