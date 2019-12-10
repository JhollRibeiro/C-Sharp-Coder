using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al1 = new Aluno(1234, "João", "111.222.333.44", "11.222.333-4", 32013);
            al1.exibe();

            Professor prf1 = new Professor(5678, "Poyatos", "999.888.777.66", "99.888.777-x", 4356); 
            prf1.exibe();

            Console.ReadKey();
        }
    }
}
