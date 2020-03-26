using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
  
    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of thrones",49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);
           

            var combo = new HashSet<Produto> {
                new Produto("Camisa",29.90),
                new Produto("8 temporada game of thrones",99.9),
                new Produto("Poster",10.90),

            };

            carrinho.UnionWith(combo);
            
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));

                Console.WriteLine($" Nome {item.Nome} Preço: {item.Preco}" );

            }
            Console.WriteLine(carrinho.Count);/
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

        }
    }
}
