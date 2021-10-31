using System;
using System.Globalization;

using Exercicio_de_Fixação_Exceções.Entities;
using Exercicio_de_Fixação_Exceções.Entities.Exceptions;

namespace Exercicio_de_Fixação_Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            string holder;

            int number;
            double balance, withdrawLimit, amount;

            Account a;

            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Withdraw(amount);

                Console.WriteLine("New balance: " + a.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(AccountException e)
            {
                Console.WriteLine("Withdraw error. " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unspected error. " + e.Message);
            }
        }
    }
}
