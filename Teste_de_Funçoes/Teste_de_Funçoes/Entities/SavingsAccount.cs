namespace Teste_de_Funçoes.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(string name, int number, double balance, double interestRate)
            : base(name, number, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double value)
        {
            Balance -= value;
            Balance -= 3.0;
        }
    }
}
