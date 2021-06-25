using System;
using System.Globalization;
using System.Collections.Generic;
using Teste_de_Funçoes.Entities;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char choice;
            int N, hours;
            double valuePerHour, additionalCharge;

            Employee e1, e2;

            List<Employee> Employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                choice = char.Parse(Console.ReadLine());

                if (choice == 'y')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Hours: ");
                    hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    e1 = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    Employees.Add(e1);
                }

                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Hours: ");
                    hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    e2 = new Employee(name, hours, valuePerHour);
                    Employees.Add(e2);
                }
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in Employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
