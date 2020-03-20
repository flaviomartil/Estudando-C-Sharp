using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private String Marca;
        private String Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);


        }
        public Moto() {


        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;

        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;

        }     public int GetCilindrada() {
           
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada) {
            if (cilindrada > 0) {
                Cilindrada = cilindrada;
            } else {
                Cilindrada = Math.Abs(cilindrada);
                //poderia ser uint :) para não permitir sinais,sendo sempre positivo
            }
        }
    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki","Ninja ZX-6R",-636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CB600");
            moto2.SetCilindrada(-600);
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}
