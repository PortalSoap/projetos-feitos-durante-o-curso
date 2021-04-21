using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_de_Fixação_List {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Employee a = new Employee(id, name, salary);
                list.Add(a);
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int consultId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == consultId);
            
            if(emp!= null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
                Console.WriteLine();
            }

            else {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
