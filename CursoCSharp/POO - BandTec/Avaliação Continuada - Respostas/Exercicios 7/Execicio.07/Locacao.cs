using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio._07
{
    class Locacao
    {
        private short codigo;
        private DateTime data; 
        private Cliente cliente;
        private Carro carro;
        
        public Locacao(short codigo, Cliente nome, Carro marca)
        {
            this.codigo = codigo;
            this.cliente = nome;
            this.carro = marca;
            this.data = DateTime.Now;
            this.QtdeEstoque--;
        }

        public Locacao()
        {
        }
        public void Exibe()
        {
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("LOCACAO");
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("Código: " + this.codigo);
            Console.WriteLine("Data: " + this.data);
            Console.WriteLine("Cliente: " + this.cliente.Nome + " - CPF: " + this.cliente.Cpf);
            Console.WriteLine("Carro: " + this.carro.Modelo + " - Marca: " + this.carro.Marca);
            Console.WriteLine("________________________");
        }

        public short GetCodigo()
        {
            return this.codigo;
        }
        public void SetCodigo(short val)
        {
            this.codigo = val;
        }

        public DateTime GetData()
        {
            return this.data;
        }
        public DateTime SetData(System.DateTime data)
        {
            return this.data;
        }

        public short GetQtdeEstoque()
        {
            return this.QtdeEstoque;
        }
        public void SetQtdeEstoque(byte valor)
        {
            this.QtdeEstoque = valor;
        }

        public string GetNome()
        {
            return this.Nome;
        }
        public void SetNome(string valor)
        {
            this.Nome = valor;
        }
        public string Cpf
        {
            get { return this.Cpf; }
            set { this.Cpf = value; }
        }
        public string Modelo
        {
            get { return this.Modelo; }
            set { this.Modelo = value; }
        }
        public string Marca
        {
            get { return this.Marca; }
            set { this.Marca = value; }
        }

        public short QtdeEstoque { get; set; }

        public string Nome { get; set; }
    }
}
