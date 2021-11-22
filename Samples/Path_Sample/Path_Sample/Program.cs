using System;
using System.IO;

namespace Path_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\Myfolder\File1.txt";

            // A classe path realiza operações com relação a um caminho de arquivo ou pasta.

            // Esta operação indica o caractére separados do sistema, ou seja, a barra invertida (\).
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            // Neste exemplo, a operação retorna o caráctere que separa caminhos, ou seja, ele mostra o caractére que separa um caminho para uma pasta de outro (;).
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            // Neste exemplo, a operação retorna o diretório (caminho) do último argumento do caminho indicado.
            // Na prática, vai falar o caminho onde está o File1.txt.
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            // Nesta operação, é retornado o nome do arquivo indicado no caminho.
            // Se não houver arquivo, será indicado a pasta que está indicado no caminho (a última pasta).
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            // Neste exemplo, é retornado também o nome do arquivo (ou pasta) mas sem a extensão, caso haja.
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            // Este aqui é a mesma coisa, só que só mostra a extensão do arquivo.
            // Caso se trate de uma pasta, nenhuma extensão é exibida.
            Console.WriteLine("GetExtension:" + Path.GetExtension(path));

            // Esta operação retorna TODO o caminho do arquivo ou pasta, indo desde o c:\.
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            // Este aqui é bem exótico. Ele retorna o caminho para a pasta temporária do sistema, a famosa temp, onde se é guardado arquivos temporários.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
