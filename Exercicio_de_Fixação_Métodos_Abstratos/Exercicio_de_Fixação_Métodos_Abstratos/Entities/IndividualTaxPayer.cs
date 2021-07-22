namespace Exercicio_de_Fixação_Métodos_Abstratos.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public IndividualTaxPayer()
        {
        }

        public IndividualTaxPayer(string name, double annualIncome, double healthExpenses)
            : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double CalculateTax()
        {
            if(AnnualIncome < 20000.0)
            {
                if(HealthExpenses > 0.0)
                {
                    return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
                }

                else
                {
                    return AnnualIncome * 0.15;
                }
            }

            else
            {
                if (HealthExpenses > 0.0)
                {
                    return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
                }

                else
                {
                    return AnnualIncome * 0.25;
                }
            }
        }
    }
}
