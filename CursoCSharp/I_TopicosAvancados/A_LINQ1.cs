using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.I_TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
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

            Console.WriteLine("== Todos ===============");
            /*
             * Passando uma função via Lambda que retorna true.
             * Entendendo:
             *  a variável 'todos' receberá o resultado da pesquisa com o critério passado na consulta,
             *  onde 'a' é cada item da lista,
             *  neste caso, retornará todos os alunos pq a função retorna 'true' e não tem nenhum critério.
             */
            var todos = alunos.Where(a => true);
            foreach (var aluno in todos)
            {
                Console.WriteLine(aluno.Nome);
            } 

            Console.WriteLine("\n== Nenhum ===============");
            var nenhum = alunos.Where(a => false);
            foreach (var aluno in nenhum)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Acima de 24 anos ===============");
            var idade = alunos.Where(a => a.Idade > 24);
            foreach (var aluno in idade)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Aprovados por Nome ascendente ===============");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Aprovados por Nome descendente ===============");
            var aprovadosDesc = alunos.Where(a => a.Nota >= 7).OrderByDescending(a => a.Nome);
            foreach (var aluno in aprovadosDesc)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Aprovados ordenados por Nota ascendente ===============");
            var notaMenor = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nota);
            foreach (var aluno in notaMenor)
            {
                Console.WriteLine($"{aluno.Nome} nota: {aluno.Nota}");
            }

            Console.WriteLine("\n== Aprovados ordenados por Nota descendente ===============");
            /*
             * Obeserve que para ordenar de dorma descendente bastou colocar o sinal de menos '-'
             * antes do intem da lista, neste caso, o 'a'.
             * 
             * Mas isso só é possível em variáveis de tipo numérica, caso use em string, gerará um erro, 
             * então deve-se usar o método OrderByDescending
             */
            var notaMaior = alunos.Where(a => a.Nota >= 7).OrderBy(a => -a.Nota);
            foreach (var aluno in notaMaior)
            {
                Console.WriteLine($"{aluno.Nome} nota: {aluno.Nota}");
            }

            /*
             * Criando uma nova lista a partir de uma lista
             * 
             * Na verdade estou selecionando para a aoutra lista apenas o atributo Nome dos itens 
             * da lista aterior.
             */
            Console.WriteLine("\n== Chamada ===============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            Console.WriteLine(chamada.GetType().Name);

            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            /*
             * Usando uma sintaxe parecidíssima com a sintaxe do SQL
             */
            Console.WriteLine("\n== Aprovados (por Idade) ===============");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}