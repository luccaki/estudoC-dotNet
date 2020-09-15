/*
Fazer um programa para ler o caminho de um arquivo .csv
contendo os dados de itens vendidos. Cada item possui um
nome, preço unitário e quantidade, separados por vírgula. Você
deve gerar um novo arquivo chamado "summary.csv", localizado
em uma subpasta chamada "out" a partir da pasta original do
arquivo de origem, contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade),
conforme exemplo.
*/
using System;
using System.Globalization;
using System.IO;

namespace Manipulando_arquivos_e_diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\lucca\Desktop\C#\Manipulando arquivos e diretorios";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath + @"\source.csv");
                Directory.CreateDirectory(sourcePath + @"\out");
                using (StreamWriter sw = File.AppendText(sourcePath + @"\out\summary.csv"))
                {
                    foreach (string line in lines)
                    {
                        string name = line.Substring(0, line.IndexOf(','));
                        string precoEQnt = line.Substring(line.IndexOf(',')+1);
                        double preco = double.Parse(precoEQnt.Substring(0, precoEQnt.IndexOf(',')),CultureInfo.InvariantCulture);
                        int qnt = int.Parse(precoEQnt.Substring(precoEQnt.IndexOf(',')+1));
                        sw.Write(name + ",");
                        sw.WriteLine((preco * qnt).ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
