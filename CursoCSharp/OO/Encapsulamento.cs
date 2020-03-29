using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNãoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroDoCelular); Não acesso pois não estou no mesmo projeto
            Console.WriteLine(JeitoDeFalar);// Herança ou internal,acesso.
            //Console.WriteLine(SegredoDeFamilia); Transmite por herança,apenas dentro do mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); PRIVATE SÓ DENTRO DA MESMA CLASSE
        }

    }
    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("AmigoDistante..");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.corDosOlhos);
            //Console.WriteLine(amiga.NumeroDOCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);

        }
    }
        class Encapsulamento {
            public static void Executar() {
                SubCelebridade sub = new SubCelebridade();
                sub.MeusAcessos();
                new FilhoReconhecido().MeusAcessos();
                new AmigoProximo().MeusAcessos();
                new FilhoNaoReconhecido().MeusAcessos();
                new AmigoDistante().MeusAcessos();
            }
        }
    }
