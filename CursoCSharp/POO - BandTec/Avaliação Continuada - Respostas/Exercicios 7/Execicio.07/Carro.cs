using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio._07
{
    class Carro
    { 
        private short codigo;
        private string marca; 
        private string modelo;
        private string categoria;
        private byte qtdeEstoque;

        public Carro(short codigo, string categoria, string marca, string modelo, byte qtdeEstoque)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.marca = marca;
            this.modelo = modelo;            
            this.qtdeEstoque = 10;
        }

        public Carro()
        {

        }
        public void Exibe()
        {
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("CARRO");
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("Código: " + this.codigo);
            Console.WriteLine("Categoria: " + this.categoria);
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Quantidade em Estoque: " + this.qtdeEstoque);
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

        public string GetMarca()
        {
            return this.marca;
        }
        public void SetMarca(string valor)
        {
            this.marca = valor;
        }
        
        public string GetModelo()
        {
            return this.modelo;
        }
        public void SetModelo(string valor)
        {
            this.modelo = valor;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }
        public void SetCategoria(string valor)
        {
            this.categoria = valor;
        }
        
        public byte GetQtdeEstoque()
        {
            return this.qtdeEstoque;
        }
        public void SetQtdeEstoque(byte valor)
        {
            this.qtdeEstoque = valor;
        }

        public string Modelo { get; set; }

        public string Marca { get; set; }
    }
}
