using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.I_TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            /*
             * Usando o Single
             * IMPORTANTE: Se tiver mais de um item na lista, isso acarretará numa exceção
             */
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            /*
             * IMPORTANTE: Caso a experssão retorne false, ou seja, não encontrar o item atraves do 
             * critério fornecido, isso acarretará numa exceção.
             * 
             * Para evitar isso utilize 'SingleOrDefault'.
             */
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            /*
             * Usando o First
             * Com o Fisrt nós contornamos a exceção gerada no Single caso haja/encontre mais de um item
             */
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            /*
             * IMPORTANTE: Caso a experssão retorne false, ou seja, não encontrar o item atraves do 
             * critério fornecido, isso acarretará numa exceção.
             * 
             * Para evitar isso utilize 'FirstOrDefault'.
             */
            var sicrano = alunos.FirstOrDefault(
                aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaDosAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDosAprovados);
        }
    }
}
