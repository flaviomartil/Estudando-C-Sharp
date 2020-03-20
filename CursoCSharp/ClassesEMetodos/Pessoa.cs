using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;
        public string Apresentar() {
            if (Nome == "" && Idade == 0) {
                return string.Format("Por favor preencha os dados");
            }
            else {
                return string.Format("Oi eu me chamo {0} e tenho {1} anos de idade", Nome, Idade);
            }
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
