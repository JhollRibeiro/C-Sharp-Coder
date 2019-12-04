using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    class A2_Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            // 'string.Format' faz mais ou menos a mesma coisa que o 'Console.WriteLine',
            // porém, retorna uma string formatada ao invés de imprir algo no console
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }  
    }
}
