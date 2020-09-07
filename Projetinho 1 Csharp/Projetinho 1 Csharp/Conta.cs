using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projetinho_1_Csharp {
    class Conta {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Dinheiro { get; private set; }

        public Conta() {
        }
        public Conta(int numero, string nome) {
            Nome = nome;
            Numero = numero;
        }

        public Conta(int numero, string nome, double dinheiro) : this(numero, nome) {
            Dinheiro = dinheiro;
        }

        public void Deposito(double quantidade) {
            Dinheiro += quantidade;
        }

        public void Saque(double quantidade) {
            Dinheiro -= quantidade + 5;
        }

        public override string ToString() {
            return "Dados da conta atualizados:\nConta " + Numero + ", Titular: " + Nome + ", Saldo: $ " +
                Dinheiro.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }

}
