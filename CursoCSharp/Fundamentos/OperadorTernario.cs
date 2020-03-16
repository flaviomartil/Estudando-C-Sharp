using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 10.0;
            var bomComportamento = true;
            var resultado = nota >= 7.0 &&bomComportamento  ? "Aprovado sua nota foi " + nota : "Reprovado sua nota foi " + (nota);

            Console.WriteLine(resultado);
            Console.WriteLine("O aluno teve bom comportamento? {0}", bomComportamento);
        }
    }
}
