using System;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System.Linq;

namespace BookStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private iBookStoreRepository repository;

        public NavigationMenuViewComponent (iBookStoreRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
