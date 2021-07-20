using System;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, lessHit;

            int[] t;
            string[] input;

            n = int.Parse(Console.ReadLine());
            t = new int[n];

            input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                t[i] = int.Parse(input[i]);
            }

            lessHit = t[0];
            p = 1;

            for (int j = 1; j < t.Length; j++)
            {
                if (t[j] < lessHit)
                {
                    lessHit = t[j];
                    p = j + 1;
                }
            }

            Console.WriteLine(p);
        }
    }
}