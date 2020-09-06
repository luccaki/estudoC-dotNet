using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_5 {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString() {
            if (NotaFinal() >= 60) {
                return "NOTA FINAL: " + NotaFinal() + "\nAprovado";
            }
            else {
                return "NOTA FINAL: " + NotaFinal() + "\nReprovado\nFaltaram " + (60 - NotaFinal()) + " Pontos"; 
            }
        }
    }
}
