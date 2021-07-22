using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_de_Fixação_Métodos_Abstratos.Entities;

namespace Exercicio_de_Fixação_Métodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char choice;

            int n, employees;
            double annualIncome, healthTaxes, totalTaxes;

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                choice = char.Parse(Console.ReadLine());

                if(choice == 'i')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Annual income: ");
                    annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures: ");
                    healthTaxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new IndividualTaxPayer(name, annualIncome, healthTaxes));
                }

                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Annual income: ");
                    annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    employees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new CompanyTaxPayer(name, annualIncome, employees));
                }
            }

            totalTaxes = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer t in taxPayers)
            {
                Console.WriteLine(t.Name + ": $ " + t.CalculateTax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += t.CalculateTax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
