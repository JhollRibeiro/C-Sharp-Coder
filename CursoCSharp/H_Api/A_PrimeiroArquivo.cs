using System;
using System.IO;

namespace CursoCSharp.H_Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            /*
             * Por que usar o '@' no inicio de uma string?
             * Para que o C# nterprete essa string em sa forma literal, ou seja, exatamente da 
             * forma como foi definida/escrita.
             * 
             * Por exemplo, se eu definir uma string que usa carateres internos como o '\t' ou o '\n'
             * ao ler essa string o C# dará um tab e quebrará uma linha, já usando o '@' isso nao ocorre.
             * 
             * var a = "\documentos\teste\novo\arquivo.txt";
             * Observe que as palavras 'teste' e 'novo' são antecedidas por '\', logo, '\t' e '\n'.
             */
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            Console.WriteLine(path);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("");
                    sw.WriteLine("É possível");
                    sw.WriteLine("adicionar");
                    sw.WriteLine("mais texto!");
                }
            }
        }
    }
}
