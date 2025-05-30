﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen
{
    public class ViewProcessedOrderUseCase : IViewProcessedOrderUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewProcessedOrderUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetProcessedOrders();
        }
    }
}
