using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, res;
            Console.WriteLine("Vamos Calcular seu IMC? \nDigite seu peso:");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite agora sua altura:");
            altura = float.Parse(Console.ReadLine());

            res = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + res);

            if (res < 18.5)
                Console.WriteLine("Você esta abaixo do peso!");

            if ((res >= 18.5) && (res < 25))
                Console.WriteLine("Você no peso ideal!");

            if ((res >= 25) && (res < 30))
                Console.WriteLine("Você esta acima do peso!");

            if (res >= 30)
                Console.WriteLine("Você esta obeso!");

            Console.ReadKey();
        }
    }
}
