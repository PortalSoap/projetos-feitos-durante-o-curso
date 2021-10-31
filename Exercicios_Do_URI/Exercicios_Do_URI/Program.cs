using System;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, q, r, i;
            string[] x;
            bool condition;

            x = Console.ReadLine().Split(' ');
            a = int.Parse(x[0]);
            b = int.Parse(x[1]);

            q = 0;
            r = 0;
            i = 0;
            condition = false;



            while (i * b >= a)
            {
                if (a > 0 && b < 0 || a < 0 && b > 0)
                {
                    q = i;
                    i--;

                    r = a - q * b;
                    if (r < 0)
                    {
                        q--;
                        r = a - q * b;
                    }
                }

                else
                {
                    q = i;
                    i++;

                    r = a - q * b;
                    if (r < 0)
                    {
                        q++;
                        r = a - q * b;
                    }
                }
                condition = true;
            }

            if (condition == false)
            {
                while (i * b <= a)
                {
                    q = i;
                    i++;
                    r = a - q * b;
                    condition = true;
                }
            }
            Console.WriteLine(q + " " + r);
        }
    }


}