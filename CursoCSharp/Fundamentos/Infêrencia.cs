using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Infêrencia {
        public static void Executar() {
            var nome = "Leonardo";
            Console.WriteLine(nome);
            var idade = 15;
            Console.WriteLine(idade);

            /*Não posso fazer var idade;
             * e idade = 15;
             * Pois ele não saberá converter porque não temos nenhum dado no var */

            //Declarei variavel
            int a;
            a = 15;
            //Declarei e inicializei a variavel
            int b = 10;

            Console.WriteLine(a + b);

        }
    }
}
