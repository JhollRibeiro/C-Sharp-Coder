using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
    abstract class ContaBancaria : IContaBancaria
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private Agencia agencia;

        internal Agencia Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }
        private Cliente cliente;

        internal Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private float saldo;

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        private List<Transacao> transacoes;

        internal List<Transacao> Transacoes
        {
            get { return transacoes; }
            set { transacoes = value; }
        }

        public ContaBancaria(int numero, Agencia agencia, Cliente cliente, float saldo)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.cliente = cliente;
            this.saldo = saldo;
            this.transacoes = new List<Transacao>();
        }
        public void VerSaldo()
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine();
            Console.WriteLine("Banco: {0}  Número do Banco: {1}", this.Agencia.Banco.Nome, this.Agencia.Banco.Numero);
            Console.WriteLine("Número da Agência: {0}.  Nome da Agência: {1}", this.Agencia.Numero, this.Agencia.Nome);
            Console.WriteLine("Cliente: {0}", this.Cliente.Nome);
            Console.WriteLine("Saldo: {0:C}", this.saldo);
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void VerExtrato()
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine();
            Console.WriteLine("Banco: {0}  Número do Banco: {1}", this.Agencia.Banco.Nome, this.Agencia.Banco.Numero);
            Console.WriteLine("Número da Agência: {0}  Nome da Agência: {1}", this.Agencia.Numero, this.Agencia.Nome);
            Console.WriteLine("Cliente: {0}", this.Cliente.Nome);
            Console.WriteLine("Saldo: {0:C}", this.saldo);
            Console.WriteLine();

            foreach (Transacao item in transacoes)
            {
                Console.WriteLine("CÓDIGO: " + item.Codigo);
                Console.WriteLine("DATA: " + item.Data);
                Console.WriteLine("TIPO: " + item.Tipo);
                Console.WriteLine("DESCRIÇÃO: " + item.Descricao);
                Console.WriteLine("VALOR: {0:c}", item.Valor);
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________");

        }

        public bool Depositar(float valor)
        {
            Random rnd = new Random();
            int cod = rnd.Next(0999, 9999);
            this.saldo = this.saldo + valor;

            Transacao tr = new Transacao(cod, "Crédito", DateTime.Now, "Depoósito em Conta", valor);
            transacoes.Add(tr);

            return true;
        }

        public bool Sacar(float valor)
        {
            Random rnd = new Random();
            int cod = rnd.Next(0999, 9999);

            if (this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;

                Transacao tr = new Transacao(cod, "Débito", DateTime.Now, "Saque em Conta", valor);
                transacoes.Add(tr);
                return true;
            }

            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

        }

        public bool Transferir(ContaBancaria cD, float valor)
        {
            bool tr1 = this.Sacar(valor);            
            bool tr2 = cD.Depositar(valor);
            if ((tr1 == true) && (tr2 == true))
            {
                return true;

            }

            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
        }
    }
}
