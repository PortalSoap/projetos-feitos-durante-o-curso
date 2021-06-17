using System;
using UpCasting_e_DownCasting_Sample.Entities;

namespace UpCasting_e_DownCasting_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Alex", 1001, 0.0);
            BusinessAccount bacc = new BusinessAccount("Maria", 1002, 0.0, 500.0);

            // Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount("Bob", 1003, 0.0, 200.0);
            Account acc3 = new SavingsAccount("Anna", 1005, 0.0, 0.01);

            // Downcasting
            BusinessAccount baac1 = (BusinessAccount)acc2;
            //acc2.Loan(100.0); Não é possível realizar isso, porque o compilador não sabe que se trata de uma váriavel BusinessAccount, apesar de ter sido feito o Upcasting.
            baac1.Loan(100.0); // Convertendo, eu consigo realizar essa façanha.

            // BusinessAccount baac2 = (BusinessAccount)acc3; Internamente será dado um erro, pois essa conversão não é possível (por se tratar de uma váriavel do tipo SavingsAccount.
            if(acc3 is BusinessAccount) // Isso é usado para verificar, se uma váriavel é uma instância da outra, e não haver erros como esse acima.
            {
                // BusinessAccount baac2 = (BusinessAccount)acc3;
                BusinessAccount baac2 = acc3 as BusinessAccount; // Outra forma de conversão, utilizando no lugar, o as.
                baac2.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                // SavingsAccount acc4 = (SavingsAccount)acc3;
                SavingsAccount acc4 = acc3 as SavingsAccount;
                acc4.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
