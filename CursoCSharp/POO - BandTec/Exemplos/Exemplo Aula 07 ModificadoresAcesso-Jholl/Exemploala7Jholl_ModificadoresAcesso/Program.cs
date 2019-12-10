using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemploala7Jholl_ModificadoresAcesso
{
    class Program 
    {
        static void Main(string[] args)
        {

            Produto prod1 = new Produto();  //Instanciação do Objeto (Criaçao do Objeto) Objeto prod1 da classe Produto

            prod1.codigo = 1; //O atributo codigo da classe Produto recebe 1

            Console.WriteLine(prod1.codigo); // imprime o codigo do Objeto prod1 da classe Produto, pq é um atributo public 

          // prod1.nome = "Água moineral"; // Erro pq é um atributo privado (private) para dar certo o atributo teria q ser public

          // prod1.preço = 2.50; //ERRO pq é um atributo protected e nao tem herança com a classe program, para dar certo teria q ter alguma herança

            prod1.ativo = true; // pode pq é do tipo internal

            prod1.SetNome("Agua mneral"); //usando o geter

            Console.WriteLine(prod1.GetNome()); // usando o setter

            prod1.Preco = 1.99f;// usando o Acessors
            
            Console.WriteLine(prod1.Preco); // usando o Acessors

            Console.WriteLine();


            Produto prod2 = new Produto(2, "Chocolate", 2.99f, false); // instanciação de um  novo objeto e preenchimento de seus atributos
            prod2.Exibe();
            

            Console.ReadLine();
        }
    }
}
