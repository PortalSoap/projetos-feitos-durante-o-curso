using System;
using Teste_de_Funçoes.Entities;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int minValue, maxValue;
            int times, result, total;
            Dice d;
            
            Console.WriteLine("Rolador de Dados.");
            Console.WriteLine();
            
            choice = "s";
            
            while (choice == "s")
            {
                total = 0;

                // Entrada dos dados.
                Console.Write("Numero mínimo: ");
                minValue = int.Parse(Console.ReadLine());

                Console.Write("Número máximo: ");
                maxValue = int.Parse(Console.ReadLine());

                Console.Write("Quantos dados? ");
                times = int.Parse(Console.ReadLine());

                for (int i = 1; i <= times; i++)
                {
                    d = new Dice(minValue, maxValue);
                    result = d.Roll();
                    
                    Console.WriteLine($"Resultado {i}: {result}");
                    total += result;
                }
                Console.WriteLine("Total das rolagens: " + total);

                Console.WriteLine();
                Console.Write("Deseja recomeçar (s/n)? ");
                choice = Console.ReadLine();

                while (choice != "s" && choice != "n")
                {
                    Console.Write("Deseja recomeçar (s/n)? ");
                    choice = Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Obrigado por utilizar!");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
