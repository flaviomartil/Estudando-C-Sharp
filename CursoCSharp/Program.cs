﻿using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;

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
            });

            central.SelecionarEExecutar();
        }
    }
}