using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            var consoleColor = Console.BackgroundColor;
            int numeroVezes = 1;
            do {
                --numeroVezes;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Qual o seu nome? ");
                Console.BackgroundColor = ConsoleColor.Black;
                entrada = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Seja bem vindo {0} você tem {1} tentativas", entrada, numeroVezes);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Deseja continuar?(S/N)");

                entrada = Console.ReadLine();
                if (numeroVezes == 0) {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Acabaram as tentativas");


                    entrada = "n";
                }

            } while (entrada.ToLower() == "s");

            if (entrada.ToLower() == "n") {
                Console.WriteLine("Até logo,agradecemos pelo uso do programa");
                Console.BackgroundColor = consoleColor;
            }


        }


    }
}
