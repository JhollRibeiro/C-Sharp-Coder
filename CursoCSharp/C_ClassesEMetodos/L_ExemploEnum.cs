using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    /*
     *Aqui implicitamento o C# adiciona um valor para a parte inteira do Enum,
     *sendo este o valor do idice
     */
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    /*
     *Aqui eu seto um valor para a parte inteira do Enum
     */
    public enum Genero2
    {
        Acao = 1,
        Aventura = 3,
        Terror = 100,
        Animacao = 21,
        Comedia = 321
    };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
        public Genero2 Genero2;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

            var filme = new Filme();
            filme.Genero2 = Genero2.Comedia;
            Console.WriteLine($"{filme.Genero2} {(int)filme.Genero2}");
        }
    }
}
