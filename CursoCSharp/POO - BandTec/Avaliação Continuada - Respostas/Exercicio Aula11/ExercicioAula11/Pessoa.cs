using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula11
{
    class Pessoa
    {
        private short codigo;

        public short Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public Pessoa(short codigo, string nome, string cpf, string rg)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
        }
      
    }

}
