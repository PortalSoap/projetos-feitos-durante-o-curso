using System;
using System.Globalization;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x;

            decimal[] n = new decimal[100];

            x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n[0] = x;

            for(int i = 1; i < 100; i++)
            {
                n[i] = n[i - 1] / 2.0000M;
            }

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"N[{i}] = {Math.Round(n[i], 4).ToString("F4", CultureInfo.InvariantCulture)}");
            }
        }
    }
}