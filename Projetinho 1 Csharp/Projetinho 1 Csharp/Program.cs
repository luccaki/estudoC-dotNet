using System;
using System.Globalization;

namespace Projetinho_1_Csharp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o numero da conta:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string nome = Console.ReadLine();

            Conta conta = new Conta(num, nome);

            Console.Write("Haverá depósito inicial(s/n) ?");
            if (Console.ReadLine() == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine(conta);

            Console.Write("Entre um valor para deposito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);
        }
    }
}
