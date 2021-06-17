using System;
using System.Globalization;
using Teste_de_Funçoes.Entities;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Maria", 1001, 500.0);
            SavingsAccount sacc1 = new SavingsAccount("John", 1002, 500.0, 0.01);

            acc1.Withdraw(100.0);
            sacc1.Withdraw(100.0);

            Console.WriteLine("R$" + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("R$" + sacc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
