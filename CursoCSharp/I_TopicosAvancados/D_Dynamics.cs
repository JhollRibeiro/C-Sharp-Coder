using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.I_TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            /*
             * Como o C# é uma linguagem fortemente tipada, ou seja, vc precisa definir o tipo de dado 
             * de cada variável e após isso essa variável só poderá receber esse tipo de dado, pode ser 
             * que em eventuais casos vc possa querer atribuir um dado de outro tipo àquela mesma variável,
             * como é o caso do javascript, onde vc define um var e atribui um número e 
             * depois uma string ou uma função etc... e isso nao gera erros.
             * 
             * Para isso no C# vc deve usar o tipo 'dynamic'.
             * 
             * Veja o exemplo abaixo onde começamos com um tipo e depois passamos para outro:
             */
            dynamic meuObjeto = "teste";
            Console.WriteLine(meuObjeto);

            meuObjeto = 3;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}
