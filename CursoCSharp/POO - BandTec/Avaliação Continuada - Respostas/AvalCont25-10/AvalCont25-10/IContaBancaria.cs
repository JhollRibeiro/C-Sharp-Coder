using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalCont25_10
{
    interface IContaBancaria
    {
        void VerSaldo();


        void VerExtrato();


        bool Depositar(float valor);


        bool Sacar(float valor);

        bool Transferir(ContaBancaria cD, float valor);
        }
    }


