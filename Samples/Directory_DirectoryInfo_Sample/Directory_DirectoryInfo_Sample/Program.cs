using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\Temp\Myfolder";
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                // Os termos em "" representam máscaras de busca. "*.*" significa que qualquer nome de arquivo com qualquer extensão de arquivo pode participar da busca.
                // Na prática, "*.*" significa qualquer coisa.
                // O SearchOption.AllDirectories permite que seja realizada também uma busca dentro das possíveis subpastas nesse diretório. Assim, também vai ser listado pastas dentro de subpastas.

                // O IEnumerable é o tipo mais genérico de coleção.
                // Também é possível usar uma váriavel var para armazenar a coleção, reduzindo assim a sintaxe para chamá-la e dispensando também a necessidade da bibilioteca System.Collections.Generic.
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();

                // Aqui será feito a mesma coisa, mas com arquivos agora (trocando o Directory.EnumerateDirectories para Directory.EnumerateFiles).
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach(string s in files)
                {
                    Console.WriteLine(s);
                }

                // Agora será criado uma pasta no caminho especificado, com o uso do tipo Directory. Também é necessário nomear a pasta, tornando-a uma subpasta. Veja o exemplo:
                Directory.CreateDirectory(path + @"\newfolder");
                Directory.CreateDirectory(path + @"\pastadearquivos");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
