using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Casa
    {
        private int porta;
        private int janela;
        public int banheiro;

        public Casa(int porta, int janela, int banheiro)
        {
            this.porta = porta;
            this.janela = janela;
            this.banheiro = banheiro;
        }

        public void Exibe()
    {
        Console.WriteLine(this.porta);
        Console.WriteLine(this.janela);
        Console.WriteLine(this.banheiro);

    }
    }
}
