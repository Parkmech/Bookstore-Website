//Parker Mecham
using System;
using BookStore.Infrastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
       
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}

