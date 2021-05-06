﻿using System;
using Enum_Sample.Entities.Enums;

namespace Enum_Sample.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ","
                + Moment
                + ", "
                + Status;
        }
    }
}
