using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            /*
             *** O DESAFIO É: Acessar variável 'a' dentro do método Executar! ***
             */

            /*
             * Essas duas proxima linhas retronarão um erro 
             * pois a variavel 'a' é um membro do Objeto e não Classe.
             * E além disso, estou tentando acessar um memnbro de um Objeto 
             * a partir de um Método Estático,
             * tanto é que se eu criar um Método não Estático, 
             * aí sim seria possivel acessar diretamente o atributo.
             * 
             * Vejo o Método 'Executar2()'
             */
            //Console.WriteLine($"o valor da varilavel a é: {a}");
            //Console.WriteLine($"o valor da varilavel a é: {F_DesafioAtributo.a}");

            var desafio = new DesafioAtributo();
            Console.WriteLine($"o valor da varilavel 'a' é: {desafio.a}");

        }

        public void Executar2()
        {
            /*
             *** O DESAFIO É: Acessar variável 'a' dentro do método Executar! ***
             */

            /*
             * Essas duas proxima linhas retronarão um erro 
             * pois a variavel 'a' é um membro do Objeto e não Classe.
             * E além disso, estou tentando acessar um memnbro de um Objeto 
             * a partir de um Método Estático
             */
            Console.WriteLine($"o valor da varilavel a é: {a}");

            /*
             * Num Método não Estáticom vc não pode acessar a Classe, somente o Objeto.
             * Por esse motivo a linha a seguir retorna um erro.
             */
            //Console.WriteLine($"o valor da varilavel a é: {F_DesafioAtributo.a}");

            var desafio = new DesafioAtributo();
            Console.WriteLine($"o valor da varilavel 'a' é: {desafio.a}");

        }
    }
}
