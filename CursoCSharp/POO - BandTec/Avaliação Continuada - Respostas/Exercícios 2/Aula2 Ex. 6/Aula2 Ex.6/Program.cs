using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, res;
            Console.WriteLine("Vamos calcular o Valor líquido de seu salário?\nDigite o valor de seu salário:");
            sal = float.Parse(Console.ReadLine());

            if (sal <= 360)
                res = (sal - (sal * 0.08f));

            if ((sal > 360) && (sal < 600))
                res = (sal - (sal * 0.09f));

            if ((sal > 600) && (sal < 1200))
                res = (sal - (sal * 0.11f));

            if (sal > 1200)
                res = (sal - 132);
        }
    }
}
