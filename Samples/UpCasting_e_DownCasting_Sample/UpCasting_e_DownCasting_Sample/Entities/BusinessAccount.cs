using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_e_DownCasting_Sample.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(string holder, int number, double balance, double loanLimit)
            : base(holder, number, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
