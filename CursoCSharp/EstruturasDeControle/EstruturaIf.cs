using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            /* if (entrada == "s" || entrada == "S")
            Se a entrada for = s ou = S  
            //bomComportamento = true;
            Para simplificar bomcomportamento = entrada == s ou == S,vai dar true,já vai atribuir de forma direta o que queremos
            //bomComportamento = entrada == "s" || entrada == "S";
            */
            bomComportamento = entrada.ToLower() == "s";




            if (nota >= 9.0 && bomComportamento) {

                Console.WriteLine("Parabéns você obteve a nota {0} e um bom comportamento,seja bem vindo ao quadro de honra", nota);
            }


        }
    }
}
