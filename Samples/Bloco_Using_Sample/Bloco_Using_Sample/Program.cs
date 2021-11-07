using System;
using System.IO;

namespace Bloco_Using_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\Temp\File1.txt";

                // O using fecha automaticamente os métodos que estão em sua atribuição quando estes são terminados.
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while (streamReader.EndOfStream != true)
                        {
                            string line = streamReader.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
            finally // Um exemplo de finally, só pra manter o nível! (-;
            {
                ConsoleColor old = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aplicativo encerrado.");
                Console.ForegroundColor = old;
            }
        }
    }
}
