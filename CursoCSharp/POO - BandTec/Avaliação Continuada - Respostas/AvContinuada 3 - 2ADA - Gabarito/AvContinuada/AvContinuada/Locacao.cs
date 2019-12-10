using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvContinuada
{
    class Locacao
    {
        public int codigo;
        public DateTime data; 
        public Cliente cliente;
        public Carro carro;

        public Locacao(int codigo, Cliente cliente, Carro carro)
        {
            this.codigo = codigo;
            this.cliente = cliente;
            this.carro = carro;
            this.data = DateTime.Now;
            this.carro.qtdeEstoque--;
        }
        public Locacao()
        { }
        public void Exibe()
        {
            Console.WriteLine("LOCAÇÃO-----------");
            Console.WriteLine("Código: " + this.codigo);
            Console.WriteLine("Data: " + this.data);
            Console.WriteLine("Cliente: " + this.cliente.nome + " - " + this.cliente.cpf);
            Console.WriteLine("Cliente: " + this.carro.modelo + " - " + this.carro.marca);
            Console.WriteLine("------------------");
        }
    }
}