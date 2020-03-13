using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolação {
        public static void Executar() {
            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 5000.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco);

            Console.WriteLine("O {0} da marca {1} custa {2} reais", nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal");

            Console.WriteLine($"1+1 = {1+1}");


        }
    }
}
