﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
       public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Divisao(int a, int b) {
            return a / b;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,2));
            Console.WriteLine(calculadoraComum.Multiplicar(9,9));
            Console.WriteLine(calculadoraComum.Divisao(45,5));

        }
    }
}
