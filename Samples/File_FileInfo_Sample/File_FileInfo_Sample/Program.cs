using System;
using System.IO;

namespace File_FileInfo_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // File é um método estático e por isso, é mais fácil de usar. O problema é que ele faz uma verificação de segurança a cada uso, então, deixará o programa mais lento.
            // FileInfo é um método que precisa ser instanciado, logo, ele é mais complexo de se usar. O seu diferencial está na performance, já que ele não precisa verificar toda vez que for executado.

            string sourcePath = @"C:\Temp\File1.txt";
            string targetPath = @"C:\Temp\File2.txt";

            try
            {
                // Lógica que faz com que seja feito uma cópia de um arquivo no local especificado.
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                // Lógica que faz com que o programa copie cada linha de um arquivo e então armazene-as em um vetor de strings.
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string l in lines)
                {
                    Console.WriteLine(l);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
