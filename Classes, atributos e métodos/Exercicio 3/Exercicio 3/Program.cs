/*
 Fazer um programa para ler os valores da largura e latura de um retangulo
Em seguida, mostrar na tela o valor de sua area, perimetro e diagonal.
*/

using System;
using System.Globalization;

namespace Exercicio_3 {
    class Program {
        static void Main(string[] args) {
            Retangulo x = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");

            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + x.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO: " + x.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL: " + x.Diagonal().ToString("F2"));
        }
    }
}
