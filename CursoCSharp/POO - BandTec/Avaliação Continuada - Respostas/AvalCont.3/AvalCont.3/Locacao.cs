using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont._3
{
    class Locacao
    {
        public int codigo;
        public DateTime data; 
        public Cliente cliente;
        public Carro carro;

        public Locacao(int codigo, Cliente nome, Carro carro)
        {
            this.codigo = codigo;
            this.cliente = nome;
            this.carro = carro;
            this.data = DateTime.Now;
            this.carro.qtdeEstoque--;
        }
        public Locacao()
    {
    
    }
        public void Exibe()
        {
            Console.WriteLine("__________________________");
            Console.WriteLine();
            Console.WriteLine("LOCACAO");
            Console.WriteLine("__________________________");
            Console.WriteLine();
            Console.WriteLine("CLIENTE: " + codigo);
            Console.WriteLine(data);
            Console.WriteLine("NOME: "+cliente.nome+" CPF: "+cliente.cpf);
            Console.WriteLine("MODELO DO CARRO: "+carro.modelo+" MARCA DO CARRO: "+carro.marca);
            Console.WriteLine("__________________________");
        }



    }
}
