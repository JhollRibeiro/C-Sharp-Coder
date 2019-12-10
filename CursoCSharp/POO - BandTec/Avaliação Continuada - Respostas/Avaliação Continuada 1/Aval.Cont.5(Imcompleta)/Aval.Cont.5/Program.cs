using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval.Cont._5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte val = 1, candf = 0, candm = 0, idhex, minf = 0, midf=0, id = 0; char sexo, exp; float p = 0;

            while (val == 1)
            {
                Console.Write("Digite a idade: ");
                id = byte.Parse(Console.ReadLine());

                Console.Write("Digite o sexo. Digite M para Masculino ou F para Feminino: ");
                sexo = char.Parse(Console.ReadLine());

                while (sexo != 'M' && sexo != 'F')
                {
                    Console.Write("Sexo inválido. Digite M para masculino e F para feminino :");
                    sexo = char.Parse(Console.ReadLine());
                }

                Console.Write("Tem Experiencia? Digite S para Sim ou N para Não: ");
                exp = char.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    candm++;

                    if (id >= 45)
                        p++;
                }
                else
                {
                    candf++;
                    if (id < 21)
                        minf++;
                }

                Console.Write("Digite 0 para sair ou 1 para Novo Cadastro: ");
                val = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine(candm + "Candidatos Masculinos.");
            Console.WriteLine(candf + "Candidatos Femininos.");
        }
    }
}