﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eShop.CoreBusiness.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<OrderLineItem>();
        }
        public int? OrderId { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateProcessed { get; set;}
        public DateTime? DateProcessing { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerStateProvince { get; set; }
        public string CustomerCountry { get; set; }
        public string AdminUser { get; set; }
        public List<OrderLineItem> LineItems { get; set; }
        public string UniqueId { get; set; }

        public void AddProduct(int productId, int qty, decimal price)

        {
            var item = LineItems.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
                item.Quantity += qty;
            else 
                LineItems.Add(new OrderLineItem { ProductId = productId, Quantity = qty,
                    Price = (decimal)price,
                    OrderId = OrderId ?? 0

                });
        }
        public void RemoveProduct(int productId)
        {
            var item = LineItems.FirstOrDefault(x => x.ProductId == productId);
            if (item != null) LineItems.Remove(item);           
        }
    }
}
