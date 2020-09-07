using System;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {
            Quarto[] quartos = new Quarto[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                Console.Write("Alguel #" + (i+1) + ":\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto { Nome = nome, Email = email };
                Console.WriteLine();
            }
            Console.WriteLine("Quaros ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.Write(i + ": ");
                    Console.Write(quartos[i] + "\n");
                }
            }
        }
    }
}
