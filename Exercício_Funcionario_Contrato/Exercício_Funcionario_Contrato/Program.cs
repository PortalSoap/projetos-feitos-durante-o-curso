using System;
using System.Globalization;
using Exercício_Funcionario_Contrato.Entities;
using Exercício_Funcionario_Contrato.Entities.Enums;

namespace Exercício_Funcionario_Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerLevel level;
            Department dept;
            HourContract contracts;
            Worker worker;

            string deptName, name, monthAndYear;
            double baseSalary, valuePerHour, income;
            int n, durationInHours, month, year;
            DateTime date;

            Console.Write("Enter department's name: ");
            deptName = Console.ReadLine();
            dept = new Department(deptName);

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                durationInHours = int.Parse(Console.ReadLine());

                contracts = new HourContract(date, valuePerHour, durationInHours);
                worker.AddContract(contracts);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            monthAndYear = Console.ReadLine();
            month = int.Parse(monthAndYear.Substring(0, 2));
            year = int.Parse(monthAndYear.Substring(3));

            income = worker.Income(month, year);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " 
                + income.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
