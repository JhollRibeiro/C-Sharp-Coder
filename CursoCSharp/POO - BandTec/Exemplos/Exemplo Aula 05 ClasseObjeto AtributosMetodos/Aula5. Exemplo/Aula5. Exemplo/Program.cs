using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciaçao do Objeto
            Produto prod1 = new Produto();
            prod1.codigo = 1;
            prod1.nome = "Avaiana de Pau";
            prod1.preço = 9.99f;

            Console.WriteLine(prod1.nome);

            Produto prod2 = new Produto();
            prod2.codigo = 2;
            prod2.nome = "Camisa social Slim";
            prod2.preço = 1000.00f;

            Console.WriteLine(prod2.preço);

            prod1.ExibirDetalhes();
            prod2.ExibirDetalhes();

            prod2.DarDesconto(0.1f);
            prod2.ExibirDetalhes();

            prod2.DarDesconto(0.5f);
            prod2.ExibirDetalhes();

            Console.ReadLine();


        }
    }

    public class Produto
    {
        //Atributos
        public short codigo;
        public string nome;
        public float preço;

        //Métodos (sempre se inicia com letra maiúscula no 'visual')
        public void ExibirDetalhes()
        {
            Console.WriteLine("__________________________");
            Console.WriteLine("Código : " + this.codigo);
            Console.WriteLine("Nome : " + this.nome);
            Console.WriteLine("Preço : " + this.preço);
            Console.WriteLine("__________________________");
        }
        public void DarDesconto(float percDesconto)
        {
            float desconto;
            desconto = this.preço * percDesconto;
            this.preço = this.preço - desconto;
        }

    }

}
