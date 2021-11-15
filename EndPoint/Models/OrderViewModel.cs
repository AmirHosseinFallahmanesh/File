using Demo.Core.Enitites.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EndPoint.Models
{
    public class OrderViewModel
    {

     
        public string OrderCpde { get; set; }
        public string Store { get; set; }

        public List<SelectListItem> Stores { get; set; }

        public void StoresInit(NewOrderMasterDTO dto)
        {
            List<SelectListItem> selects = new List<SelectListItem>();
            foreach (var item in dto.Stores)
            {
                selects.Add(new SelectListItem() { Text = item.Name, Value = item.StoreId.ToString() });
            }
            this.Stores = selects;
        }
     
         

    }
}