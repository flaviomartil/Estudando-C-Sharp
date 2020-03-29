using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
  public  class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos); Não posso acessar porque é transmitido por herança
            Console.WriteLine(amiga.NumeroDoCelular);
            Console.WriteLine(amiga.JeitoDeFalar); //Ou herança ou quem é interno do mesmo projeto
            //Console.WriteLine(amiga.SegredoDeFamilia); // Só é transmitido por herança ou a mesma classe
             //Console.WriteLine(amiga.UsaMuitoPhotoshop); é privado,apenas a classe sabe.


        }
        }
    }

