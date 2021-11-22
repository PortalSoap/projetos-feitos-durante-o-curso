using System;
using System.IO;
using System.Globalization;

using Exercicio_de_Fixação_Manipulação_Arquivos.Entities;

namespace Exercicio_de_Fixação_Manipulação_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Temp\PastaExercicioFixacao_Arquivos\products.csv";
            string targetFolderPath = Path.GetDirectoryName(sourcePath);
            string targetFilePath = targetFolderPath + @"\summary.csv";

            string name;
            int quantity;
            double value;

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] section = line.Split(",");
                        name = section[0];
                        value = double.Parse(section[1], CultureInfo.InvariantCulture);
                        quantity = int.Parse(section[2]);

                        Product p = new Product(name, value, quantity);
                        sw.WriteLine(p);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
