using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {
        public class CalculadoraEstatica {
            // Método de instancia
            public  int Somar(int a, int b) {
                return a + b;

            }
            // Método de Classe ou Método Estático
            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }
        public static void Executar() {
            //Estatico,logo posso chamar diretamente pela classe
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("O resultado da multiplicação é: {0}",resultado);

            // Não statico,ou seja posso instanciar,fornecer varias variaveis
            var calculadoraEstatica = new CalculadoraEstatica();

            Console.WriteLine(calculadoraEstatica.Somar(2,4));
            
        }
    }
}
