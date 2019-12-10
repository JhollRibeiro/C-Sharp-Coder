using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio._07
{
    class Cliente
    { 
        private short codigo;
        private string nome;
        private string cpf;
         
        public Cliente(short codigo, string nome, string cpf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
        }
        public Cliente()
        {

        }
        public void Exibe()
        {
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("CLIENTE:");
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("Código: " + this.codigo);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("________________________");

        }

        public short GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(short valor)
        {
            this.codigo = valor;
        }
        
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string valor)
        {
            this.nome = valor;
        }

        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetCpf(string valor)
        {
            this.cpf = valor;
        }


        public string Nome { get; set; }

        public string Cpf { get; set; }
    }
}
