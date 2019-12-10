using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula10Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();

            num.Add(10); //Add = adiciona sempre no final
            num.Add(50);
            num.Insert(0, 20); // Insert = adiciona no inicio desde q o indice seja 0(ZERO)
            num.Insert(2, 30); // Insert =  nesse caso ele adicionou 30 no indice 2


            Console.WriteLine(num[2]);
            Console.WriteLine();

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
            

            // um outro tipo de collections HashSet (nao deixa repitir um elemento ja existente repare no ultimo numero 10 qndo peço p imprimir)

            HashSet<int> numeros = new HashSet<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(10);

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
