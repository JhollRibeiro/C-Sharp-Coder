using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemploala7Jholl_ModificadoresAcesso
{ 
    class Produto //Cria a Classe Produto
    {
        // Atributos
        public int codigo; //todo mundo acessa 

        private string nome; //somente o propio dono acessa(Classe produto) se eu rodar no man vai dar erro

        protected float preco; //meio termo entre public e private, pode ser acessado apartir da herança

        internal bool ativo;


        public Produto() // Declaraçao do metodo construtor (nesse caso vazio) nao necessita void (3 caracteristicas: rigorosamente o nome do objeto; nao retorna nada; tem q ser public)
        {
        
        }

 
        public Produto(int codigo, string nome, float preco, bool ativo)//Declaraçao do metodo construtor q recebe variaveis do tipo inteiro, string, float e bool
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.ativo = ativo;      
        }
        public void Exibe() //Declaraçao d uma Função q se chama Exibe 
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
