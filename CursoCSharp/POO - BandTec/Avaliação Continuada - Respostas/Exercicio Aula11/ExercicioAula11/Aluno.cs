using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula11
{
    class Aluno : Pessoa
    {
        private short ra;

        public short Ra
        {
            get { return ra; }
            set { ra = value; }
        }

        public Aluno(short codigo, string nome, string cpf, string rg, short ra) : base(codigo, nome, cpf, rg)
        {
            this.ra = ra;
        }

        public void exibe()
        {
            Console.WriteLine("{0} é um Aluno/(a), \nCódigo é: {1} \nCPF: {2}\nRG: {3}\nRA: {4}", this.Nome, this.Codigo, this.Cpf, this.Rg, this.ra);
            Console.WriteLine();
        }
    }
}
