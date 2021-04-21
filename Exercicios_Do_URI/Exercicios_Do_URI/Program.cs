using System;

namespace Teste_de_Funçoes {
    class Program {
        static void Main(string[] args) {

            int a, b, q, r;
            double q1, r1;
            string[] ab;

            ab = Console.ReadLine().Split();
            a = int.Parse(ab[0]);
            b = int.Parse(ab[1]);

            q1 = a / b;
            r1 = a % b;

            Math.Round(q1);
            Math.Round(r1);

            q = (int) q1;
            r = (int) r1;

            Console.WriteLine(q + " " + r);
        }
    }
}