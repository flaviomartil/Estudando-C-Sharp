using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("Digite a nota do aluno");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9) {
                Console.WriteLine("Parabéns você está no quadro de honra com a nota: {0}", nota);
            } else if(nota>=7.0) {
                Console.WriteLine("Aprovado");

            } else if (nota >= 5.0) {
                Console.WriteLine("Reprovado");
            } else {
                Console.Write("Te vejo na proxima");
            }

            Console.WriteLine("FIM");
        }
    }
}
