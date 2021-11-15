using Demo.Core.Enitites;
using System;
using System.Collections.Generic;

namespace Demo.Core.Contract
{
    public interface IOrderRepository
    {

        int SaveOrder(Order order);

        List<Order> GetAllOrder();

        Order GetOrder(int id);



    }
}
