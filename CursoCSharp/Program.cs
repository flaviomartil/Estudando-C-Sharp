using System;
using System.Collections.Generic;

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
            });

            central.SelecionarEExecutar();
        }
    }
}