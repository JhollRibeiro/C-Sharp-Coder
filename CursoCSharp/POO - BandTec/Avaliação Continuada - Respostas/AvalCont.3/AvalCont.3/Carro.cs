using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont._3
{
    class Carro
    {
        public int codigo;
        public string marca;
        public string modelo;
        public string categoria;
        public int qtdeEstoque;

        public Carro(int codigo, string categoria, string marca, string modelo, int qtdeEstoque)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
            this.categoria = categoria;
            this.qtdeEstoque = 10;
        }
        public Carro()
        {
        }
        public void Exibe()
        {
            Console.WriteLine("__________________________");
            Console.WriteLine();
            Console.WriteLine("CARRO");            
            Console.WriteLine("__________________________");
            Console.WriteLine();
            Console.WriteLine("CÓDIGO DO CARRO: " + codigo);
            Console.WriteLine("CATEGORIA DO CARRO: " + categoria);
            Console.WriteLine("MARCA DO CARRO: " + marca);
            Console.WriteLine("MODELO DO CAROO: " + modelo);
            Console.WriteLine("QNDE EM ESTOQUE: " + qtdeEstoque);
            Console.WriteLine("__________________________");

        }


    }
}
