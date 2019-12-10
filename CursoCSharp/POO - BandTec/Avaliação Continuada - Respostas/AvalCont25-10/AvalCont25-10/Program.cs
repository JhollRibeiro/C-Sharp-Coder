using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b1 = new Banco(3215, "Bradesco");
            Agencia ag1 = new Agencia(3454, "Flórida", b1);
            Cliente cl1 = new Cliente("João Ribeiro", "888.777.666-90");
            ContaEspecial ce1 = new ContaEspecial(7634, ag1, cl1, 5000, 1200);
            ContaPoupanca cp1 = new ContaPoupanca(100763, ag1, cl1, 1200, DateTime.Now);

            ce1.Depositar(800);
            cp1.Depositar(450);

            ce1.Sacar(950);
            cp1.Sacar(200);

            ce1.Transferir(cp1, 600);

            cp1.RenderJuros(0.08f);

            ce1.VerSaldo();
            ce1.VerExtrato();

            cp1.VerExtrato();




            Console.ReadKey();
        }
    }
}
