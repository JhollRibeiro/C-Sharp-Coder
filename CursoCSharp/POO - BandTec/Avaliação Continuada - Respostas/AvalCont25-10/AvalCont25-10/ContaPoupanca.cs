using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
	class ContaPoupanca : ContaBancaria
	{
        private DateTime diaAniversario;

        public DateTime DiaAniversario
        {
            get { return diaAniversario; }
            set { diaAniversario = value; }
        }


		public ContaPoupanca(int numero, Agencia agencia, Cliente cliente, float saldo, DateTime diaAniversario)
			: base(numero, agencia, cliente, saldo)
		{
			this.diaAniversario = diaAniversario;
		}

		public bool RenderJuros(float valor)
		{
			Random rnd = new Random();
			int cod = rnd.Next(0999, 9999);

			DateTime time = DateTime.Now;

            if (this.diaAniversario.ToString() == time.ToString("d"))
            {
                this.Saldo = Saldo + (Saldo * valor);
                Transacao tr = new Transacao(cod, "Crédito", DateTime.Now, "Rendimentos", Saldo);

                return true;
            }
            else
            {
                return false;
            }
		}
        
	}
}
