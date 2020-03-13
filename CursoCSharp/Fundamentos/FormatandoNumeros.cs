using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F3")); // 3 CASAS DECIMAIS
            Console.WriteLine(valor.ToString("C")); // CURRENCY - DINHEIRO
            Console.WriteLine(valor.ToString("P")); //PORCENTUAL 
            Console.WriteLine(valor.ToString("#.##")); // DECIMAIS DE ACORDO O USER

            CultureInfo cultura = new CultureInfo("EN-US"); // ESTOU SETANDO A MOEDA DOS EUA
            Console.WriteLine(valor.ToString("C3", cultura)); // ESTOU ESCREVENDO UM CURRENCY + 3 CASAS DECIMAIS + O TIPO DA MOEDA (DOLAR $)


            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // AQUI ESTOU DIZENDO QUE O NÚMERO DEVE TER 10 POSIÇÕES

        }
    }
}