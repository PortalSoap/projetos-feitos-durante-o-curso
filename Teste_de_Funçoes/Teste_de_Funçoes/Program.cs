using System;
using Teste_de_Funçoes.Entities;
using Teste_de_Funçoes.Entities.Enums;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 4032,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);
        }
    }
}
