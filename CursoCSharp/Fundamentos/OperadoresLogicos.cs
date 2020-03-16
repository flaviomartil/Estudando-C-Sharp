using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;

            Console.WriteLine("Comprou a tv de 50 polegadas? : {0}", comprouTv50);
            Console.WriteLine("A familia tomou sorvete ?  {0}", comprouSorvete);
            Console.WriteLine("Comprou a tv de 32 polegadas?  {0}", comprouTv32);
            Console.WriteLine("Mais saudavel?  {0}", !comprouSorvete);







        }
    }
}
