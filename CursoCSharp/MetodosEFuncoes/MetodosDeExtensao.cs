using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        } 
        public static double Subtracao(this double num, double outroNumero) {
            // this e tipo faz com que seja uma função de extensão
            return num - outroNumero;

        }
    }
    class MetodosDeExtensao {
        
        public static void Executar() {
            int numero = 5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(3.Soma(3));
            Console.WriteLine(2.9.Subtracao(3));

        }
    }
}
