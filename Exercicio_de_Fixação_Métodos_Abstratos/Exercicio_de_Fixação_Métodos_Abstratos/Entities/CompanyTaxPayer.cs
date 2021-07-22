using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Fixação_Métodos_Abstratos.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTaxPayer()
        {
        }

        public CompanyTaxPayer(string name, double annualIncome, int employees)
            : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double CalculateTax()
        {
            if(Employees <= 10)
            {
                return AnnualIncome * 0.16;
            }

            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
