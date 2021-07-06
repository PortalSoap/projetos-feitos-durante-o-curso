using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_de_Fixação_Polimorfismo_2.Entities;

namespace Exercicio_de_Fixação_Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char choice;
            int n;
            double price, customsFee;
            DateTime manufactureDate;

            Product prd;

            List<Product> allProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                choice = char.Parse(Console.ReadLine());

                if(choice == 'c')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prd = new Product(name, price);
                    allProducts.Add(prd);
                }

                else if(choice == 'u')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    prd = new UsedProduct(name, price, manufactureDate);
                    allProducts.Add(prd);
                }

                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prd = new ImportedProduct(name, price, customsFee);
                    allProducts.Add(prd);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in allProducts)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
