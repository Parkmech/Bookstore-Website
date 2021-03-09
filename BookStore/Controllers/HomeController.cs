//Parker Mecham, Section 1 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Models;
using BookStore.Models.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private iBookStoreRepository _repository;
        //Sets the number of books per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, iBookStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            //Creates the page numbering data  
            return View(new BookListViewModel
            {
                Books = _repository.Books
                        .OrderBy(b => b.bookId)
                        .Where(b => category == null || b.Category == category)
                        .Skip((pageNum - 1) * PageSize)
                        .Take(PageSize)
                    ,
                //Sets the items on the page equal to the full repository unless one of the categories has been selected,
                //then it sets it equal to whichever category is selected. 
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Books.Count() :
                        _repository.Books.Where(x => x.Category == category).Count()
                },

                CurrentCategory = category

            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
