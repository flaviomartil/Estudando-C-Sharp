using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        // Todos
        public string InfoPublica = "Tenho um instagram";
        //Herança
        protected string CorDosOlhos = "Verde";
        //Mesmo projeto (Assembly)
        internal ulong NumeroDoCelular = 5511996569596;
        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";
        // Mesma classe ou herança no mesmo projeto
        private protected string SegredoDeFamilia = "bla bla bla";
        // Private é o padrão
        bool UsaMuitoPhotoshop = true;
        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade..");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);

        }
    }
}
