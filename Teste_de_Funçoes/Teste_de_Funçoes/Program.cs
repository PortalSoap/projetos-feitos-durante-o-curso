using System; 

namespace Teste_de_Funçoes {
    class Program {
        static void Main(string[] args) {

            int contagemDeChars;
            string entrada;

            contagemDeChars = 0;
            entrada = Console.ReadLine();


            foreach(char obj in entrada) {
                contagemDeChars++;
            }

            Console.WriteLine("Your string has " 
                + contagemDeChars + " char(s).");
        }
    }
}
