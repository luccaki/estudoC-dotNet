/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Listas {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();
            Console.Write("How many employee will be registered? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write("Emplyoee #" + (i + 1) + ":\n" + "Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine();

                Employee employee = new Employee(id, name, salary);
                employees.Add(employee);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine());
            if (employees.Find(x => x.Id == id2) != null) {
                Employee test = employees.Find(x => x.Id == id2);
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                test.IncreaseSalary(percent);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list os employees: ");
            foreach (Employee obj in employees) {
                Console.WriteLine(obj);
            }
        }
    }
}
