using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.C_ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() { }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            /*
             * Uma vez que eu instacio um Objeto passando o valor de um atributo estático
             * esse valor será aplicado a todos os proximos objetos instaciados 
             * até que haje uma alteração no valor desse atributo,
             * que tbm será aplicado para todos os objetos instanciados daí pra frente
             * pois se trata de um atributo da Classe e não do Objeto.
             * 
             * Neste caso, passamos um valor padrão no contrutor desse Obejto e 
             * como esse atributo faz parte do contrutor devemos passar um valor 
             * durante a instanciação do Objeto, substituindo assim o valor pádrão passado no construtor.
             */
            var produto1 = new Produto("Caneta", 3, 0.2);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5
            };

            Console.WriteLine("Preço produto1 com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço produto2 com desconto: {0}", produto2.CalcularDesconto()); 

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço produto1 com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço produto2 com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço produto1 com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço produto2 com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
