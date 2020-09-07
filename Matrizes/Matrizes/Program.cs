/*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.
*/

using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            string[] entrada = new string[2];
            entrada = Console.ReadLine().Split(' ');
            int linha = int.Parse(entrada[0]);
            int coluna = int.Parse(entrada[1]);
            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++) {
                string[] entrada2 = new string[coluna];
                entrada2 = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++) {
                    matriz[i, j] = int.Parse(entrada2[j]);
                }
            }

            int busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++) {
                for (int j = 0; j < coluna; j++) {
                    if (matriz[i, j] == busca) {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j + 1 < linha) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i + 1 < coluna) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
