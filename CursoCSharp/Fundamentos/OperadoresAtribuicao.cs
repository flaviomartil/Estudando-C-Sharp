using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 += 10; // Num = NUM + 10
            num1 -= 3; // Num = NUM + 10
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine("O valor do NUM é: {0}", num1);

            int a = 1;
            int b = a;
            a++; //a = a + 1
            b--; // b = b - 1 

            Console.WriteLine("O valor de A é {0} e o valor de B é igual a {1}", a, b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joão";

            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine(c.nome);

            
        }
    }
}
