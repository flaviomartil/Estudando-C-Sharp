using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public struct Dependente {
        public string Nome;
        public int Idade;

    }
    class ValorVsReferencia {
      
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            numero++;
            Console.WriteLine("{0} {1}", numero, copiaNumero);
            Dependente dep = new Dependente {
                Nome = "Flávio",
                Idade = 21
            };
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
            copiaDep.Nome = "Renato";
            dep.Idade = 29;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
