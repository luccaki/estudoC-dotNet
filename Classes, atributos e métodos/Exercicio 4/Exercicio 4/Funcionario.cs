using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_4 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double pers) {
            SalarioBruto += (SalarioBruto * (pers / 100));
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido();
        }
    }
}
