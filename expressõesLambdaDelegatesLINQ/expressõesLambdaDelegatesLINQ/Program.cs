/*
Fazer um programa para ler os dados (nome, email e salário)
de funcionários a partir de um arquivo em formato .csv.
Em seguida mostrar, em ordem alfabética, o email dos
funcionários cujo salário seja superior a um dado valor
fornecido pelo usuário.
Mostrar também a soma dos salários dos funcionários cujo
nome começa com a letra 'M'.
*/

using System;
using expressõesLambdaDelegatesLINQ.Entities;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace expressõesLambdaDelegatesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double sal = double.Parse(line[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, sal));
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + " :");

            var output = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach(string o in output)
            {
                Console.WriteLine(o);
            }

            Console.Write("Sum of salary of people whose name starts with 'M': ");
            var sum = employees.Where(p => p.Name.IndexOf('M')==0 ).Select(p => p.Salary).Sum();
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
