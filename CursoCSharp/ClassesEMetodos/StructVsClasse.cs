using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;

    }public class CPonto {
        public int X;
        public int Y;

    }
    class StructVsClasse {
       public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 2 };
            SPonto copiaSPonto = ponto1;
            ponto1.X = 10;
            Console.WriteLine("O valor do ponto  é {0}",ponto1.X); // É 10 FOI INSTANCIADO
            Console.WriteLine("O valor do ponto  é {0}",copiaSPonto.X); // É 1 O STRUCT RESPEITA A Atribuição

            CPonto cponto1 = new CPonto { X = 2, Y =  20 };
            CPonto copiaCPonto1 = cponto1;
            cponto1.X = 22;
            Console.WriteLine("O valor do ponto 2 é {0}",cponto1.X);
            Console.WriteLine("O valor do ponto 2 é {0}",copiaCPonto1.X);
            //Ambos serão Iguais devido a classe referenciar
        }
    }
}
