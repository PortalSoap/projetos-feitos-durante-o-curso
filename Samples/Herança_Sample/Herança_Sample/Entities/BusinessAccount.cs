namespace Herança_Sample.Entities
{
    class BusinessAccount : Account // Basta fazer isso para dizer ao compilador que você quer que ele herde as caracteristicas da classe que você colocou.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) // Basta colocar isso para que seja herdado os valores de um construtor.
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
