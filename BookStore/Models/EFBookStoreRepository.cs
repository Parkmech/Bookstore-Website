//Parker Mecham, Section 1

using System;
using System.Linq;

namespace BookStore.Models
{
    public class EFBookStoreRepository : iBookStoreRepository
    {
        private BookStoreDBContext _context;

        //Constructor
        public EFBookStoreRepository (BookStoreDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;

    }
}
