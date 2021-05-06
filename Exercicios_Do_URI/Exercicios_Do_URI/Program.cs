using System;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int QT;
            long sum, n1, n2;
            string[] inputString, inputInt;

            QT = int.Parse(Console.ReadLine());
            for(int i = 0; i < QT; i++)
            {
                inputString = Console.ReadLine().Split();
                inputInt = Console.ReadLine().Split();

                n1 = int.Parse(inputInt[0]);
                n2 = int.Parse(inputInt[1]);
                sum = n1 + n2;

                if (inputString[1] == "PAR" && sum % 2 == 0
                    || inputString[1] == "IMPAR" && sum % 2 != 0)
                {
                    Console.WriteLine(inputString[0]);
                }
                else
                {
                    Console.WriteLine(inputString[2]);
                }
            }
        }
    }
}