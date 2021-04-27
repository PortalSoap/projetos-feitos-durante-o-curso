using System;

namespace Teste_de_Funçoes {
    class Program {
        static void Main(string[] args) {

            int n, c, soma;
            soma = 0;

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                c = int.Parse(Console.ReadLine());
                for (int j = 1; j <= c; j++) {
                    if (j == 1) {
                        soma += 1;
                    }
                    else if (j % 2 == 0) {
                        soma -= 1;
                    }
                    else {
                        soma += 1;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}