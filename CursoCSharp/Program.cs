using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios  - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes  - Fundamentos", VariaveisEConstantes.Executar},
                {"Infêrencia  - Fundamentos", Infêrencia.Executar},
                {"Interpolação  - Fundamentos", Interpolação.Executar},
                {"Notação Ponto  - Fundamentos", NotaçãoPonto.Executar},
                {"Lendo Dados  - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros  - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões  - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos  - Fundamentos", OperadoresAritméticos.Executar},
                {"Operadores Relacionais  - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos  - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição  - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios  - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario   - Fundamentos", OperadorTernario.Executar},
                // Estruturas de controle

                {"Estrutura IF   - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura IF / ELSE   - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura IF / ELSE / ELSEIF   - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch  - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While  - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile  - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For  - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura Estrutura ForEach  - Estruturas de controle", EstruturaForEach.Executar},
                {"Estrutura Break  - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue  - Estruturas de controle", UsandoContinue.Executar},
                // Classes e Metódos
                {"Membros  - Classes e métodos", Membros.Executar},
                {"Construtores  - Classes e métódos", Construtores.Executar},
                {"Métodos Com Retorno  - Classes e métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos  - Classes e métodos", MetodosEstaticos.Executar},
                {"Métodos Atributos Estaticos  - Classes e métodos", AtributosEstaticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}