using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Produto //cria a classe Produto
    {
        //Atributos
        public int codigo; // Todos acessam
        private string nome; //só a propria classe
        protected float preco;  
        internal bool ativo;

        public Produto()
        {
        }

        public Produto(int codigo, string nome, float preco, bool ativo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.ativo = ativo;
        }
        public void Exibe()
        {
            Console.WriteLine(this.codigo);
            Console.WriteLine(this.nome);
            Console.WriteLine(this.preco);
            Console.WriteLine(this.ativo);
        }

        //geter do nome
        public string GetNome()
        {
            return this.nome;
        }
        //Setter do nome
        public void SetNome(string valor)
        {
            this.nome = valor;
        }

       
        //Acessors
        public float Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }
        

    }
}
