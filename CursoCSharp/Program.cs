using System;
using System.Collections.Generic;

using CursoCSharp.A_Fundamentos;
using CursoCSharp.B_EstruturasDeControle;
using CursoCSharp.C_ClassesEMetodos;
using CursoCSharp.D_Colecoes;
using CursoCSharp.E_OO;
using CursoCSharp.F_MetodosEFuncoes;
using CursoCSharp.G_Excecoes;
using CursoCSharp.H_Api;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                #region FUNDAMENTOS
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTrenario.Executar},
                #endregion

                #region ESRTRUTURAS DE CONTROLE
                { "Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                { "Estrutura IF/ELSE - Estruturas de Controle", EstruturaIF_ELSE.Executar},
                { "Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIF_ELSE_IF.Executar},
                { "D_EstruturaSwitch - Estruturas de Controle", EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                { "Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                { "Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                #endregion

                #region CLASSES E MEMBROS
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                { "Struct VS Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetro com Valor Padrão - Classes e Métodos", ParemetroComValorPadrao.Executar},
                #endregion

                #region COLEÇÕES
                { "Arrays - Coleções", Arrays.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColoecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},
                #endregion

                #region ORIENTAÇÃO A OBJETO
                { "Herança - Orientação a Obejto", Heranca.Executar},
                { "Construtor This - Orientação a Obejto", ConstrutorThis.Executar},
                { "Encapsulamento - Orientação a Obejto", E_OO.Encapsulamento.Executar},
                { "Polimorfismo - Orientação a Obejto", Polimorfismo.Executar},
                { "Classe Abstrata - Orientação a Obejto", Abstract.Executar},
                { "Interfaces - Orientação a Obejto", Interface.Executar},
                { "Classe Selada - Orientação a Obejto", Sealed.Executar},
                #endregion

                #region MÉTODOS E FUNÇÕES
                { "Lambda - Métodos e Funçoes", ExemploLambda.Executar},
                { "Lambdas Como Delegates - Métodos e Funçoes", LambdasDelegate.Executar},
                { "Usando Delegates - Métodos e Funçoes", UsandoDelegates.Executar},
                { "Delegates com Funções Anonimas - Métodos e Funçoes", DelegateFuncAnonima.Executar},
                { "Delegates como Parâmetros - Métodos e Funçoes", DelegatesComoParametros.Executar},
                { "Métodos de Extensão - Métodos e Funçoes", MetodosDeExtensao.Executar},
                #endregion

                #region EXCEÇÕES
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                #endregion

                #region Explorando a API do C#
                { "Primeiro Arquivo - Exceções", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - Exceções", LendoArquivos.Executar},
                { "Exemplo File-Info - Exceções", ExemploFileInfo.Executar},
                { "Diretórios - Exceções", Diretorios.Executar},
                #endregion
            });

            central.SelecionarEExecutar();
        }
    }
}