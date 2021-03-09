using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookStore.Models;
using BookStore.Infrastructure;

namespace BookStore.Pages
{
    public class BuyModel : PageModel
    {
        private iBookStoreRepository repository;

        //Constructor
        public BuyModel (iBookStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //Properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }


        //Methods
        public void OnGet(string returnUrl)
        {

            ReturnUrl = returnUrl ?? "/";

            //PREVIOUS METHOD Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //New Method
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books

                .FirstOrDefault(p => p.bookId == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.bookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        /* PREVIOUS METHOD
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.bookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        */
    }
}
