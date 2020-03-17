using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            //for (int i = 1; i <= 10; i++) {
            //    Console.WriteLine("O valor de i é: {0}", i);
            //    i += 1;

            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for (int i = 1; i <= tamanhoDaTurma; i++) {
                Console.Write("Informe a nota do aluno {0}:  ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
      
            }
            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine("A média da turma é de: {0}",media);
        }
    }
}
