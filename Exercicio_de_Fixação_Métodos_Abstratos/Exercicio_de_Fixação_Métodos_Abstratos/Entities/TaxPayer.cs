namespace Exercicio_de_Fixação_Métodos_Abstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; protected set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalculateTax();
    }
}
