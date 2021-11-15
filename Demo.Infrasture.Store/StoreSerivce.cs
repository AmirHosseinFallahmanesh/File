using Demo.Core.Enitites;
using System;
using System.Collections.Generic;

namespace Demo.Infrasture.Stores
{
    public class StoreSerivce
    {

        public List<Store> GetAll()
        {
            return new List<Store>()
            {
                new Store(){Name="store1",StoreId=1,Type=true},
                 new Store(){Name="store2",StoreId=2,Type=false},
            };
        }
    }
}
