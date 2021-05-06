using System;
using Teste_de_Funçoes.Entities.Enums;

namespace Teste_de_Funçoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Id: "
                + Id
                + ", Moment: "
                + Moment.ToShortDateString()
                + ", Status: "
                + Status;
        }
    }
}
