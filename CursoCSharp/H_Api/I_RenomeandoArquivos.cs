using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.H_Api
{
    class RenomeandoArquivos
    {
        public static void Executar()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Music\Deezloader Music\Loved tracks");

            FileInfo[] infos = dir.GetFiles();

            foreach (FileInfo file in infos)
            {
                // Pegar somente arquivos desse tipo, pois no folfer há tbm imagens 
                if (file.Attributes.ToString().ToLower() == "archive")
                {
                    /**
                     * Amostra do nome de um arquivo a ser alterado
                     * Antes:   182 - Pra Sempre Deus - Rodrigo Torres-Frei Gilson.mp3
                     * Depois: 0182 - Pra Sempre Deus - Rodrigo Torres-Frei Gilson.mp3
                     */
                    var split = file.Name.Split('-');

                    var novoNome = int.Parse(split[0]).ToString("D4") + " ";

                    for (int i = 1; i < split.Length; i++)
                    {
                        novoNome += "-" + split[i];
                    }

                    File.Move(file.FullName, file.FullName.Replace(file.Name.ToString(), novoNome));
                    //File.Move(f.FullName, f.FullName.Replace("abc_", ""));
                }
            }
        }

    }
}
