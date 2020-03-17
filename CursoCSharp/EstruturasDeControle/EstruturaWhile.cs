using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            var corAnterior = Console.BackgroundColor;
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestante = 5;
            int tentativas = 0;

            while(tentativasRestante > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;
                tentativasRestante--;

                if(numeroSecreto == palpite) {
                    numeroEncontrado = true;
                
                       
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas, Parabéns !",tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite>numeroSecreto) {
                    Console.WriteLine("O número é menor,tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestante);
                }
                else if(palpite<numeroSecreto) {
                    Console.WriteLine("O número é maior,tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestante);
                }
              
            }

            if (tentativasRestante == 0) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Você perdeu :(");

                Console.BackgroundColor = corAnterior;

            }

        }
    }
}
