using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula_Relacionamentos_1porN
{
    class Time
    {
        private int codigo;

        public int Codigo
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

        private byte qtde;

        public byte Qtde
        {
            get { return qtde; }
        }

        public Time(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.qtde = 0;
        }

        private Jogador[] jogadores = new Jogador[11];

        public void AddJogador(Jogador j)
        {
            this.jogadores[this.qtde] = j;
            this.qtde++;
        }

        public void Exibe()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Qtde de Jogadores: {0}", this.Qtde);
            Console.WriteLine("------------");

            foreach (Jogador j in this.jogadores)
            {
                
            }
        }
    }
}
