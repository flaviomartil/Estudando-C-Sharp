using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CarroOpcional {
        double desconto = 0.1;
        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedades Autoimplementada
        public double Preco { get; set; }
        // Propriedade somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // LAMBDA
         
            //get {
            //    return Preco -(desconto * Preco);
            //}
        }
        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            Preco = preco;

        }
    }
    class Propriedades {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.99);
            Console.WriteLine("O valor com desconto é: {0}",op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direçao Elétrica";
            op2.Preco = 2349.99;

            Console.WriteLine("{0}",op1.Nome);
            Console.WriteLine("{0}",op2.Preco);
            Console.WriteLine("{0}",op2.PrecoComDesconto);
        }
    }
}
