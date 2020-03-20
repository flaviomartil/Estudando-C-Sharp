using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
         readonly DateTime Nascimento;
        const int x = 1;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
            Nascimento = new DateTime(2020, 10, 10);
            //o valor atribuido no construtor fica imutavel pelo readonly
        }
        public string GetDataDeNascimento() {
          return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class ReadOnly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana silva", new DateTime(1987, 01, 20));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
