using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Area da circunfêrencia 
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;
            //COMO É UMA CONSTANTE NÃO PODE SER ALTERADO
            //PI = 3.15;  
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é: " + area);
            //Assim que se faz uma soma a uma variavel
            //Console.WriteLine("A area é: " + (area + 1000)); 

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("A idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salario maximo é: " + salario);

            int menorValorInt = int.MinValue;// Mais usado dos inteiros !!
            Console.WriteLine("Menor valor inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;

            Console.WriteLine("O total de população brasileira é de: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;

            Console.WriteLine("O menor valor do long é: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;

            Console.WriteLine("A população mundial é de: " + populacaoMundial);

            float precoComputador = 1299.79f;

            Console.WriteLine("O preço do computador é: " + precoComputador);

            double valorDeMercadoDaApple = 10000000000000000.00;

            Console.WriteLine("O Valor de mercado da apple é " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;

            Console.WriteLine("Distancia entre as estrelas é " + distanciaEntreEstrelas);

            char letra = 'b';

            Console.WriteLine("A letra é " + letra);
        }
    }
}
