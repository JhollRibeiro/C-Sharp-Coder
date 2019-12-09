using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.H_Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            // Exibe somente o dia da data
            Console.WriteLine(diaAtual.ToString("dd"));

            // Exibe a data no formato 'dd/mm/aaaa' de acordo com o SO
            Console.WriteLine(diaAtual.ToString("d"));

            // Exibe a data completa formatada 'segunda-feira, 9 de dezembro de 2019' de acordo om o SO
            Console.WriteLine(diaAtual.ToString("D"));

            // Exibe data e hora, porém hora sem os segundos '09/12/2019 10:49'
            Console.WriteLine(diaAtual.ToString("g"));

            // Exibe data e hora, porém hora com os segundos '09/12/2019 10:49:09'
            Console.WriteLine(diaAtual.ToString("G"));

            // Formata de acordo com o parametro passado na chamada do método 'ToSatring()'
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
