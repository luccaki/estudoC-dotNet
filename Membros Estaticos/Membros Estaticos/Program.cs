/*
 * Faça um programa para ler a cotação do dollar, e depois um valor em dolares a ser comprado por uma pessoas em reais
 * Informar quantos reias a pessoa vai pagar pelo dolares, considerando ainda a taxa de 6% de IOF
 */

using System;
using System.Globalization;

namespace Membros_Estaticos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar?: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar?: ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em rais: "+ ConversorDeMoeda.Dolar(cot,dol).ToString("F2",CultureInfo.InvariantCulture));]
        }
    }
}
