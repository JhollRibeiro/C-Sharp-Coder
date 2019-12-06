﻿using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.D_Colecoes
{
    class C_ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);
            //arraylist.Count

            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
