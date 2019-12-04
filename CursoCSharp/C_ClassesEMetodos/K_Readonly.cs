using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(year:2020, month:10, day:10);
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }

    class K_Readonly
    {
        static public void Executar()
        {
            var novoCliente = new Cliente("Ana Silva",
                new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            // novoCliente.Nascimento = new DateTime(2020, 10, 10);
        }
    }
}
