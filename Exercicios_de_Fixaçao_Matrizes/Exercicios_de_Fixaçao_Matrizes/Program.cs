using System;

namespace Exercicios_de_Fixaçao_Matrizes {
    class Program {
        static void Main(string[] args) {
            string[] v = Console.ReadLine().Split(" ");
            int M = int.Parse(v[0]);
            int N = int.Parse(v[1]);

            int[,] numbers = new int[M, N];

            for(int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(" ");
                for(int j = 0; j < N; j++) {
                    numbers[i, j] = int.Parse(s[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i < M; i ++) {
                for(int j = 0; j < N; j++) {
                    if(numbers[i, j] == x){
                        Console.WriteLine("Position " + i + "," + j + ":");

                        // Left
                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + numbers[i, j - 1]);
                        }
                        
                        // Up
                        if(i - 1 >= 0) {
                            Console.WriteLine("Up: " + numbers[i - 1, j]);
                        }

                        // Right
                        if(j + 1 < N) {
                            Console.WriteLine("Right: " + numbers[i, j + 1]);
                        }

                        // Down
                        if(i + 1 < M) {
                            Console.WriteLine("Down: " + numbers[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
