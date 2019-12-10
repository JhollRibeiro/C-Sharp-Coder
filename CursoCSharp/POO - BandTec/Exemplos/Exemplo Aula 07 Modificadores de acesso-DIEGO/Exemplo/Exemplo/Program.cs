using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando 
            Produto prod1 = new Produto(); 
            prod1.codigo = 1;
            Console.WriteLine(prod1.codigo);
           // prod1.nome = "Água mineral";      // > da erro, atributo privado, não é pra fazer;
           // prod1.preco = 1.99f; // também vai dar erro
            prod1.ativo = true; // So pode interno
            prod1.SetNome("Agua mneral"); //usando o geter
            Console.WriteLine(prod1.GetNome()); // usando o setter
            prod1.Preco = 1.50f;// ussando o Acessors
            Console.WriteLine(prod1.Preco); // usando o Acessors
                

            Produto prod2 = new Produto(2,"Chocolate", 2.99f, true);

            prod2.Exibe();

            Casa minha = new Casa(4, 10, 3);
            minha.Exibe();

            Produto prod3 = new Produto(3, "Cama", 200.45f, true);
            prod3.Exibe();


            prod1.SetNome("Saaaoopopo");
            prod1.Exibe();

            Console.ReadKey();

        }
    }
}
