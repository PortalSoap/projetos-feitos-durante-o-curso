using System;
using Exercicio_de_Fixação_Exceções.Entities.Exceptions;

namespace Exercicio_de_Fixação_Exceções.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance <= 0.0)
            {
                throw new AccountException("There's no sufficient balance.");
            }
            if(amount > WithdrawLimit)
            {
                throw new AccountException("The amount is larger than your limit.");
            }

            Balance -= amount;
        }
    }
}
