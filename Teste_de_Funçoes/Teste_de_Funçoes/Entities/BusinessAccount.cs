namespace Teste_de_Funçoes.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(string name, int number, double balance, double loanLimit)
            : base(name, number, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double value)
        {
            if(value <= LoanLimit)
            {
                Balance += value;
            }
        }
    }
}
