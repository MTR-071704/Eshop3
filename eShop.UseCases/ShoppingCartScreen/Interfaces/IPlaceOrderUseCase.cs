﻿using eShop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Excute(Order order);
    }
}