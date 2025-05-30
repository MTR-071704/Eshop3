﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using eShop.UseCases.ShoppingCartScreenn.Interfaces;
using eShop.UseCases.ViewProductScreen.Interfaces;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase

    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public Task<Order> Execute() // 
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
