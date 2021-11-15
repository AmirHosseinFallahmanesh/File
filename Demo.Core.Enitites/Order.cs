using System;
using System.Collections.Generic;

namespace Demo.Core.Enitites
{
    public class Order
    {
        public int OrderId { get; set; }
        List<OrderDetail> OrderDetails { get; set; }
          public DateTime OrderDate { get; set; }
        public OrderState OrderType { get; set; }
    }
}
