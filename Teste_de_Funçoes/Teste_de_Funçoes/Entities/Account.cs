namespace Teste_de_Funçoes.Entities
{
    class Account
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(string name, int number, double balance)
        {
            Name = name;
            Number = number;
            Balance = balance;
        }

        public void Add(double value)
        {
            Balance += value;
        }

        public virtual void Withdraw(double value)
        {
            Balance -= value;
            Balance -= 5.0;
        }
    }
}
