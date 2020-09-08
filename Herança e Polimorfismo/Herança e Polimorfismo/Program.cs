using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using Herança_e_Polimorfismo.Entities;

namespace Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the numbers of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char data = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (data == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name,price, customsFee));
                }
                else if (data == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else 
                {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS:");
                foreach (Product x in list) 
                {
                    Console.WriteLine(x.PriceTag());
                }
            }
        }
    }
}
