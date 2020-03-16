using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota) {
                case 0:
                    Console.WriteLine("O atendimento foi Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("O atendimento foi Ruim");
                    break;
                case 3:
                    Console.WriteLine("O atendimento foi Regular");
                    break;
                case 4:
                    Console.WriteLine("O atendimento foi Bom");
                    break;
                case 5:
                    Console.WriteLine("O atendimento foi Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota invalida,por favor digitar uma nota valida");
                    break;
            }
            Console.WriteLine("Obrigado por responder");
        }
    }
}
