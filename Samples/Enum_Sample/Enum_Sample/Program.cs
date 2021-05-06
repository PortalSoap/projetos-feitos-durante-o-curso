using Enum_Sample.Entities;
using Enum_Sample.Entities.Enums;
using System;

namespace Enum_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Conversão de "enum" para "string".
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Conversão de "string" para "enum".
            // OBS: Tem de ser um valor existente, ou então vai dar erro.
            OrderStatus oc = Enum.Parse<OrderStatus>("Deliverd");
            Console.WriteLine(oc);
        }
    }
}
