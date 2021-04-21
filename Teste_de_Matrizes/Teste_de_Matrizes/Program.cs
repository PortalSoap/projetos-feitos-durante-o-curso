using System;

namespace Teste_de_Funções {
    class Program {
        static void Main(string[] args) {
            int N;
            N = int.Parse(Console.ReadLine());

            int[,] matriz;
            matriz = new int[N, N];

            // Entrada dos dados da matriz.
            for(int i = 0; i < N; i++) {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(v[j]);
                }
            }

            // Cálculo e saída.
            int soma = 0;
            for(int i = 0; i < N; i++) {
                for(int j = 0; j < N; j++) {
                    if(i == j) {
                        soma += 0;
                    }
                    else if (i > 0 && j > 0) {
                        soma += matriz[i - 1, j];
                    }
                }
            }

            Console.WriteLine(soma);

        }
    }
}
