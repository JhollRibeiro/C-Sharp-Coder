using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.E_OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        /*
         * A palavra 'virtual' permite que o método seja sobrescrito por filhos das Classe Carro
         */
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        /*
         * BASE é o construtor base da Classe pai, que neste caso é Carro,
         * que obrigatoriamente eu tenho que implementar por se tratar de uma Herança,
         * uma vez que a Classe Carro não tem um construtor padrão, ou seja, umcontrutor vazio.
         * 
         * Observe que ele recebe um valor por padrão, que é a velocidade máxima, 
         * que foi implementada no construtor da Classe Carro.
         */
        public Uno() : base(200) 
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        /*
         * Caso a Classe pai nao tenha abordado o acesso 'virtual' na assinatura do método
         * não seria possível sobrescrevê-lo aqui
         */
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        /*
         * Oculta o método da classe Pai
         * 
         * Neste caso, a classe pai não precisa abordar o acesso 'virtual'
         * 
         * A diferença entre ocultar e sobrescrever um método é que quando eu chamar a partir 
         * do polimorfismo, ou seja, criar um objeto filho a partir do tipo pai, o metodo chamado será sempre
         * o método da classe pai, já na sobrescrita, o método chamado será o da classe filho.
         * 
         * Veja o exemplo no carro 3.
         */
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
