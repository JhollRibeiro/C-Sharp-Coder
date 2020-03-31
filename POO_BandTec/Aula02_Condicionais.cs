using System;

namespace POO_BandTec
{
    public class Aula02_Condicionais
    {
        public static void Executar()
        {
            var continuar = "s";

            /*
             * Exercício 4:
             * Elabore um algoritmo que calcule o que deve ser pago por um produto,
             * solicitando que o usuário digite o seu preço de etiqueta e a condição de
             * pagamento desejada (número de 1 a 4). Utilize os códigos da tabela a seguir
             * para ler qual a condição de pagamento escolhida e efetuar o cálculo adequado.
             * Exiba o valor em tela conforme indicado.
             */
            do
            {
                Console.Write("Digite o valor do produto: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha a forma de pagamento:\n" +
                    "Digite 1 para: A vista em dinheiro ou Cheque.\n" +
                    "Digite 2 para: Cartão de Crédito.\n" +
                    "Digite 3 para: Em duas vezes.\n" +
                    "Digite 4 para: Em três vezes.");
                short forma = short.Parse(Console.ReadLine());
                /*
                if (forma == 1)
                    Console.WriteLine($"valor a ser pago: {(valor -= (valor * 0.1)).ToString("C")}");
                else if (forma == 2)
                    Console.WriteLine($"valor a ser pago: {(valor -= (valor * 0.05)).ToString("C")}");
                else if (forma == 3)
                    Console.WriteLine($"valor a ser pago é de duas parcelas de: {(valor / 2).ToString("C")}");
                else if (forma == 4)
                    Console.WriteLine($"valor a ser pago é de três parcelas de: {((valor += (valor * 0.1)) / 3).ToString("C")}");
                    */

                switch (forma)
                {
                    case 1:
                        Console.WriteLine($"valor a ser pago: {(valor -= (valor * 0.1)).ToString("C")}");
                        break;
                    case 2:
                        Console.WriteLine($"valor a ser pago: {(valor -= (valor * 0.05)).ToString("C")}");
                        break;
                    case 3:
                        Console.WriteLine($"valor a ser pago é de duas parcelas de: {(valor / 2).ToString("C")}");
                        break;
                    case 4:
                        Console.WriteLine($"valor a ser pago é de três parcelas de: {((valor += (valor * 0.1)) / 3).ToString("C")}");
                        break;
                }

                Console.WriteLine("Deseja continuar?(S/N)");
                continuar = Console.ReadLine();
            }
            while (continuar.ToLower() == "s");
            Console.WriteLine("===========\n");

            /*
             * Exercício 3:
             * Escreva um algoritmo que leia três valores inteiros e mostre-os em ordem
             * decrescente. Utilize condicionais encadeadas. (Não utilize arrays ou laços!)
             */

            do
            {
                int troca, v2, v3, maior;
                Console.Write("Digite o primeiro valor inteiro: ");
                maior = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor inteiro: ");
                v2 = int.Parse(Console.ReadLine());
                if (v2 > maior)
                {
                    troca = maior;
                    maior = v2;
                    v2 = troca;
                }

                Console.Write("Digite o terceiro valor inteiro: ");
                v3 = int.Parse(Console.ReadLine());
                if (v3 > maior)
                {
                    troca = maior;
                    maior = v3;
                    v3 = troca;
                }

                if (v3 > v2)
                {
                    troca = v2;
                    v2 = v3;
                    v3 = troca;
                }

                Console.WriteLine($"Ordem decrescente ods números digitados: {maior}, {v2} e {v3}.");
                Console.WriteLine("Deseja continuar?(S/N)");
                continuar = Console.ReadLine();
            }
            while (continuar.ToLower() == "s");
            Console.WriteLine("===========\n");

            /*
             * Exercício 2: 
             * Solicite que o usuário digite 4 notas bimestrais de um aluno,
             * calcular sua situação em relação a sua aprovação.
             * Um aluno está aprovado se a média aritmética das 4 notas bimestrais for uma
             * média igual ou maior que 7,0.
             * Caso a média seja maior ou igual a 7,0 deverá ser exibida a mensagem:
             * “Aluno Aprovado, parabéns!”, caso a média seja inferior a 7,0 deverá ser
             * exibida a mensagem “Aluno Reprovado, estude mais!”
             * Média Aritmética: (N1 + N2 + N3 + N4)/4
             * Obs.: Assumir que as 4 notas informadas são válidas.
             */
            var i = 0;
            var media = 0.0;

            do
            {
                Console.Write("Digite sua nota: ");
                double nota = double.Parse(Console.ReadLine());

                while (nota < 0 || nota > 10)
                {
                    Console.Write("A nota digitada é inválida!\nDigite novamente: ");
                    nota = double.Parse(Console.ReadLine());
                }
                media += nota;
                i++;
            }
            while (i < 4);

            Console.WriteLine((media /= 4) < 7 ? "Aluno Reprovado, estude mais!" : "Aluno Aprovado, parabéns!" + $". Média: {media}.");
            Console.WriteLine("===========\n");


            /* 
             * Exercício 1:
             * Entre com a idade via teclado e informe o seguinte:
             * Caso a entrada seja maior que 18 anos, mostrará:
             * “Já é maior”, caso contrário “Ainda é menor”
             */
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine(idade > 18 ? "Já é maior" : "Ainda é menor");
            Console.WriteLine("===========\n");

        }
    }
}
