using System;
using System.Globalization;
using Exercicio_de_Fixação_Enumeração_e_Composição.Entities;
using Exercicio_de_Fixação_Enumeração_e_Composição.Entities.Enums;

namespace Exercicio_de_Fixação_Enumeração_e_Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, productName;
            int N, quantity;
            double productPrice;
            DateTime birthDate;

            OrderItem item;
            OrderStatus status;
            Product product;
            Client client;
            Order order;

            Console.WriteLine("Enter client data:");
            
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            birthDate = DateTime.Parse(Console.ReadLine());

            client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                
                Console.Write("Product name: ");
                productName = Console.ReadLine();

                Console.Write("Product price: ");
                productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                product = new Product(productName, productPrice);
                item = new OrderItem(quantity, productPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
