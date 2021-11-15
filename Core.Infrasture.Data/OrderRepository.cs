using Demo.Core.Contract;
using Demo.Core.Enitites;
using System;
using System.Collections.Generic;

namespace Core.Infrasture.Data
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAllOrder(Order order)
        {
            return null;
        }

        public List<Order> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            return null;
        }

  

        public int SaveOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
