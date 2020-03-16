using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            Console.WriteLine("Digite a sua nota para saber se foi aprovado: ");
            var nota = Console.ReadLine();
            var notaDouble = double.Parse(nota);


            if (notaDouble >= 7) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Você não fez mais do que sua obrigação");

            }
            else {
                Console.WriteLine("Recuperação");
            }

        }
    }
}
