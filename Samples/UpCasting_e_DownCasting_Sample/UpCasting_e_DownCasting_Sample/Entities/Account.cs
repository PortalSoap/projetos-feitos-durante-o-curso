namespace UpCasting_e_DownCasting_Sample.Entities
{
    class Account
    {
        public string Holder { get; set; }
        public int Number { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(string holder, int number, double balance)
        {
            Holder = holder;
            Number = number;
            Balance = balance;
        }

        public void Add(double amount)
        {
            Balance += amount;
        }

        public void Remove(double amount)
        {
            Balance -= amount;
        }
    }
}
