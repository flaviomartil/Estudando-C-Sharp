using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    sealed class Semfilho {
        public double ValorDaFortuna() {
            return 14000000000000000;
        }
    }
    class Vo {
        public virtual bool HonrarNomeDaFamilia() {
            return true;
        } // aqui é opcional honrar,pois o método da classe vo pode ser sobrescrito
    }
    class Pai : Vo {
        public override sealed bool HonrarNomeDaFamilia() {
            return true;// agora não é mais permitdo a sobrescrita,você tem de honrar.

        }
    }
    //class Soufilho : Semfilho {

    //} Não vai funcionar porque classe sealed não pode ser herdada !
    class FilhoRebelde: Pai {
        public new bool HonrarNomeDaFamilia() {
            return true;
        }
    }
    class Sealed {
        public static void Executar() {

        }
    }

  
}
