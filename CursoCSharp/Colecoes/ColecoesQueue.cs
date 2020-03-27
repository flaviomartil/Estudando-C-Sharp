using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();
            fila.Enqueue("fulano");
            fila.Enqueue("siclano");
            fila.Enqueue("beltrano");

            Console.WriteLine(fila.Peek()); //Primeiro item da fila,sem remover
            Console.WriteLine(fila.Count);//Conta o número de itens na fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);//Conta o número de itens na fila

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
                
            }
            var salada = new Queue();
            salada.Enqueue(2);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.72);

            Console.WriteLine(salada.Contains("item"));

        }
    }
}
