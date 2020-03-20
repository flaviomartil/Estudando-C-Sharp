using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa ciclano = new Pessoa();
            ciclano.Nome = "Flávio";
            ciclano.Idade = 21;

            //Console.WriteLine("O {0} tem {1} anos de idade", ciclano.Nome, ciclano.Idade);
            //Console.WriteLine(ciclano.Apresentar());
            ciclano.ApresentarNoConsole();
            ciclano.Zerar();
            Console.WriteLine(ciclano.Apresentar()); 
            var fulano = new Pessoa();
            fulano.Nome = "beto";
            fulano.Idade = 23;
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);

        }

    }
}
