/*
 Fazer um programa para ler o nome de um aluno e as 3 primeiras notas dele(primeira vale 30 e segunda e terceira vale 35)
Ao final, mostrar qual a nota final do aluno
Dizer tambem se o aluno foi aprovado ou não, e em caso negativo, quantos pontos faltam para o launo obter o minimo para ser aprovado(60 pontos)
*/

using System;
using System.Globalization;

namespace Exercicio_5 {
    class Program {
        static void Main(string[] args) {

            Aluno x = new Aluno();

            Console.Write("Nome do Aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}
