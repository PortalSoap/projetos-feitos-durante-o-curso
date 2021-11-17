using System;
using System.IO;

namespace StreamWriter_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"c:\Temp\File1.txt";
                string targetPath = @"c:\Temp\File2.txt";

                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter streamWriter = File.AppendText(targetPath)) // Mais um exemplo do using, que fecha toda e qualquer Stream que for colocado em sua atribuição assim que for terminada.
                {
                    foreach(string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper()); // O StreamWritter, assim como o nome diz, tem a finalidade de escrever caractéres em arquivos.
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
