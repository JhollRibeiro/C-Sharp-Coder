using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula_Relacionamentos_1porN
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador objJogador1 = new Jogador(1, "Allejo", 18, "atacante");
            Time objTime = new Time(1, "Seleção Brasileira");
            Jogador objJogador2 = new Jogador(2, "Gomez", 22, "atacante");

            objTime.AddJogador(objJogador1);
            objTime.AddJogador(objJogador2);

            Console.WriteLine(objTime.Qtde); 
            Console.Read();
        }
    }
}
