/*
 fazer um programa para ler os dados de um funcionario(Nome, salario e imposto)
Em seguida, mostrar os dados do funcionario(Nome e salario liquido)
Em seguida, aumentar o salario do funcionario com base em uma porcentagem
dada (somente o salario bruto é afetado pela porcentagem) e mostrar
novamente os dados do funcionario
*/

using System;
using System.Globalization;

namespace Exercicio_4 {
    class Program {
        static void Main(string[] args) {
            Funcionario x = new Funcionario();
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + x);
            Console.Write("Digite a Porcentagem para aumentar o salario: ");
            x.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Funcionario: " + x);

        }
    }
}
