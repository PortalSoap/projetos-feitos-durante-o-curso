using System;

namespace Matrix_Sample {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];

            // Impressão de quantos espaços tem essa matriz por meio do Lenght.
            Console.WriteLine(mat.Length);

            // Função que exibe quantas dimensões um arranjo tem.
            Console.WriteLine(mat.Rank);

            //Função que exibe as dimensões de uma matriz (linha, que é 0 ou coluna, que é 1)
            Console.WriteLine(mat.GetLength(0));
        }
    }
}
