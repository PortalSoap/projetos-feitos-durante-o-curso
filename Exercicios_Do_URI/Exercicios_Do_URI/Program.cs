using System;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, q, r;
            string[] input;

            input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);

            q = 0;
            r = 0;

            if (a > 0 && b > 0)
            {
                for (int i = 1; b * q + r != a; i++)
                {
                    if (i * b > a)
                    {
                        q = i - 1;
                        r = a - b * q;
                    }
                }
            }

            else if (a < 0 && b > 0)
            {
                for (int i = 1; b * q > a; i--)
                {
                    if (i * b < a)
                    {
                        q = i;
                    }
                }

                for (int i = 1; b * q + r != a; i++)
                {
                    r = i;
                }
            }

            else
            {
                for (int i = 1; b * q + r != a; i--)
                {
                    if (i * b > a)
                    {
                        q = i + 1;
                        r = a - b * q;
                    }
                }
            }
            Console.WriteLine(q + " " + r);
        }
    }
}