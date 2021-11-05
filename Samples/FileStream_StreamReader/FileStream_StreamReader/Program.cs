using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\File1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                // Este construtor utiliza um método onde é necessário inserir um caminho e um modo de operação.
                // Utilizei nesse caso, o FileMode.Open. Essa função se encarrega de abrir um arquivo já existente, mas há várias outras funções dentro do FileMode.
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream); // Para se criar um StreamReader, é necessário antes criar um FileStream.

                // Também há uma forma reduzida, se obtendo os mesmos resultados. No lugar de criar um atributo genérico FileStream para então se criar um StreamReader, é possível utilizar o File.OpenText(), informando o caminho do arquivo dentro dos parênteses, e então, fazendo as adaptações necessárias.
                // O File.OpenText já utiliza o processo do FileStream, por isso, não precisamos instanciar esse atributo.
                
                // Dessa maneira, mostramos todas as linhas de um arquivo.
                while (streamReader.EndOfStream != true)
                {
                    // Para mostrar só uma linha, basta utilizar este código, sem a estrutura while.
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred.");
                Console.WriteLine(e.Message);
            }
            finally // O bloco finally sempre é executado, independentemente se uma exceção ocorreu ou não durante a aplicação.
            {
                // Quando se utiliza os métodos FileStream e StreamReader, há uma conversa externa, com o sistema operacional Windows. Isso quer dizer que temos que fechar esses processos manualmente.
                if (streamReader != null)
                {
                    // O comando Close fecha esse processo.
                    streamReader.Close();
                }
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
