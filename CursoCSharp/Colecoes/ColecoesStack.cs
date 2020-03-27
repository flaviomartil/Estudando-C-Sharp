using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach(var item in pilha) {
                Console.WriteLine("Listando "+ item +" " );
            }
            Console.WriteLine(pilha.Count);
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Count);
        }
    }
}
