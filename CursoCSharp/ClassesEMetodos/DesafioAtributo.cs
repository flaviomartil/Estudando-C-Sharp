using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;
    
        public static void Executar() {
            //acessar variavel a de dentro do metódo executar
            DesafioAtributo acessando = new DesafioAtributo();
            Console.WriteLine(acessando.a);

        }
    }
}
