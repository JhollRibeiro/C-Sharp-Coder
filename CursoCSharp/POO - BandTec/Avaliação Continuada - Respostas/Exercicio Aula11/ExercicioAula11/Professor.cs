using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula11
{
    class Professor : Pessoa
    {
        private int regFunc;

        public int RegFunc 
        {
            get { return regFunc; }
            set { regFunc = value; }
        }

        public Professor(short codigo, string nome, string cpf, string rg, int regFunc) : base(codigo, nome, cpf, rg)
        {
            this.regFunc = regFunc;
        }

        public void exibe()
        {
            Console.WriteLine("{0} é um professor/(a), \nCódiogo é: {1} \nCPF: {2}\nRG: {3} \nRegitro: {4}",this.Nome, this.Codigo, this.Cpf, this.Rg, this.regFunc);
            Console.WriteLine();
        }

    }
}
