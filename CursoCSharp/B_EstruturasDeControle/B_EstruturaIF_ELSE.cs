﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.B_EstruturasDeControle
{
    class B_EstruturaIF_ELSE
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
