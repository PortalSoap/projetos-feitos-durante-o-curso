using System;
using System.Globalization;

namespace Exercicio4_EstruturaFor {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if(escolha < 0 || escolha > 7) {
                Console.WriteLine("Qual o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }

            else if(escolha == 1) {
                // Exercicio 1
                int x;
                x = int.Parse(Console.ReadLine());
                for(int i = 1; i <= x; i++) {
                    if(i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }

            else if(escolha == 2) {
                // Exercicio 2
                int N;
                N = int.Parse(Console.ReadLine());
                int dentro = 0;
                int fora = 0;
                for(int i = 0; i < N; i++) {
                    int x = int.Parse(Console.ReadLine());
                    if(x >= 10 && x <= 20) {
                        dentro++;
                    }
                    else {
                        fora++;
                    }
                }
                Console.WriteLine($"{dentro} in");
                Console.WriteLine($"{fora} out");
            }

            else if(escolha == 3) {
                // Exercicio 3
                int N;
                N = int.Parse(Console.ReadLine());
                for(int i = 0; i < N; i++) {
                    string[] v = Console.ReadLine().Split(' ');
                    double x = double.Parse(v[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(v[1], CultureInfo.InvariantCulture);
                    double z = double.Parse(v[2], CultureInfo.InvariantCulture);
                    double media = ((x * 2.0) + (y * 3.0) + (z * 5.0)) / (2.0 + 3.0 + 5.0);
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            else if(escolha == 4) {
                // Exercicio 4
                int N;
                N = int.Parse(Console.ReadLine());
                for(int i = 0; i < N; i++) {
                    string[] v = Console.ReadLine().Split(' ');
                    int x = int.Parse(v[0]);
                    int y = int.Parse(v[1]);
                    if (y == 0) {
                        Console.WriteLine("divisao impossivel");
                    }
                    else {
                        double divisao = (double) x / y;
                        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }

            else if(escolha == 5) {
                // Exercicio 5
                int n = int.Parse(Console.ReadLine());
                int fat = 1;
                for (int i = 1; i <= n; i++) {
                    fat = fat * i;
                }
                Console.WriteLine(fat);
            }

            else if(escolha == 6) {
                int n;
                n = int.Parse(Console.ReadLine());
                for(int i = 1; i <= 6; i++) {
                    if(n % i == 0) {
                        Console.WriteLine(i);
                    }
                }
            }

            else {
                int N;
                N = int.Parse(Console.ReadLine());
                for(int i = 1; i <= N; i++) {
                    int quadrado = i * i;
                    int cubo = i * i * i;
                    Console.Write($"{i} {quadrado} {cubo}");
                    Console.WriteLine();
                }
            }










        }
    }
}
