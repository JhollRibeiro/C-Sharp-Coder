using System;
using System.Collections.Generic;

using CursoCSharp.A_Fundamentos;
using CursoCSharp.B_EstruturasDeControle;
using CursoCSharp.C_ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // FUNDAMENTOS
                { "Primeiro Programa - Fundamentos", A_PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", B_Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", C_VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", D_Inferencia.Executar},
                {"Interpolação - Fundamentos", E_Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", F_NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", G_LendoDados.Executar},
                {"Formatando Números - Fundamentos", H_FormatandoNumero.Executar},
                {"Conversões - Fundamentos", I_Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", J_OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", K_OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", L_OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", M_OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", N_OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", O_OperadorTrenario.Executar},

                // ESRTRUTURAS DE CONTROLE
                { "Estrutura IF - Estruturas de Controle", A_EstruturaIF.Executar},
                { "Estrutura IF/ELSE - Estruturas de Controle", B_EstruturaIF_ELSE.Executar},
                { "Estrutura IF/ELSE/IF - Estruturas de Controle", C_EstruturaIF_ELSE_IF.Executar},
                { "D_EstruturaSwitch - Estruturas de Controle", D_EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas de Controle", E_EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de Controle", F_EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de Controle", G_EstruturaFor.Executar},
                { "Estrutura For Each - Estruturas de Controle", H_EstruturaForEach.Executar},
                { "Usando Break - Estruturas de Controle", I_UsandoBreak.Executar},
                { "Usando Continue - Estruturas de Controle", J_UsandoContinue.Executar},

                // CLASSES E MEMBROS
                { "Membros - Classes e Métodos", A1_Membros.Executar},
                { "Construtores - Classes e Métodos", B_Construtores.Executar},
                { "Metodos com Retorno - Classes e Métodos", C_MetodosComRetorno.Executar},
                { "Metodos Estáticos - Classes e Métodos", D_MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", E_AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", F_DesafioAtributo.Executar},
                { "Params - Classes e Métodos", G_Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", H_ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", I_GetSet.Executar},
                { "Props - Classes e Métodos", J_Props.Executar},
                { "Readonly - Classes e Métodos", K_Readonly.Executar},
                { "Exemplo Enum - Classes e Métodos", L_ExemploEnum.Executar},
                { "Exemplo Struct - Classes e Métodos", M_ExemploStruct.Executar},
                { "Struct VS Classe - Classes e Métodos", N_StructVsClasse.Executar},
                { "Valor VS Referência - Classes e Métodos", O_ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos", P_ParametrosPorReferencia.Executar},
                { "Parâmetro com Valor Padrão - Classes e Métodos", Q_ParemetroComValorPadrao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}