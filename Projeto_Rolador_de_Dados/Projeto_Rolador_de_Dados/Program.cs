using System;
using Projeto_Rolador_de_Dados.Entities;

namespace Projeto_Rolador_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            int quantity, maxValue, result;
            string[] typeOfDice;

            RollQuantity rollQuantity;
            Dice d;
            
            Console.WriteLine("Rolador de Dados");
            Console.WriteLine("Ex: 1d20, 3d6, 4d10");
            Console.WriteLine();

            choice = 's';

            while (choice == 's')
            {
                Console.Write("Rolagem: ");
                typeOfDice = Console.ReadLine().Split("d");

                quantity = int.Parse(typeOfDice[0]);
                maxValue = int.Parse(typeOfDice[1]);

                rollQuantity = new RollQuantity(quantity);
                d = new Dice(maxValue);

                result = d.Roll(rollQuantity);

                Console.WriteLine(d);
                Console.WriteLine("Total Final: " + result);
                Console.WriteLine();

                Console.Write("Deseja reiniciar (s/n)? ");
                choice = char.Parse(Console.ReadLine());
                while (choice != 's' && choice != 'n')
                {
                    Console.Write("Deseja reiniciar (s/n)? ");
                    choice = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}
