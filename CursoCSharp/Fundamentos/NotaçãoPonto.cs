using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotaçãoPonto {
        public static void Executar() {
            var saudacao = "ola ".ToUpper().Insert(4, "World").Replace("World", "Mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            
        }
    }
}
