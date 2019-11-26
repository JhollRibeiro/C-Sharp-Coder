using System;
using System.Collections.Generic;

using CursoCSharp._1_Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", _1_PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", _2_Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", _3_VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", _4_Inferencia.Executar},
                {"Interpolação - Fundamentos", _5_Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", _6_NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", _7_LendoDados.Executar},
                {"Formatando Números - Fundamentos", _8_FormatandoNumero.Executar},
                {"Conversões - Fundamentos", _9_Conversoes.Executar},
                {" Operadores Aritiméticos - Fundamentos", _10_OperadoresAritimeticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}