using Demo.Core.Contract;
using Demo.Core.Enitites;
using Demo.Core.Enitites.DTO;
using Demo.Infrasture.Stores;
using System;
using System.Collections.Generic;

namespace Demo.Core.ApplicatoinService
{
    public class OrderFacade:IOrderFacade
    {
        private readonly IOrderRepository orderRepository;

        public OrderFacade(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public NewOrderMasterDTO NewOrderHeader()
        {
            StoreSerivce storeSerivce = new StoreSerivce();
            int orderCode = new Random().Next(10000, 90000);
            List<Store> stores = storeSerivce.GetAll();

            NewOrderMasterDTO result = new NewOrderMasterDTO()
            {
                OrederCode = orderCode,
                Stores = stores
            };

        return result;
    }

        public void AddOrder()
        {

            orderRepository.SaveOrder(new Order());
           
        }




    }
}
