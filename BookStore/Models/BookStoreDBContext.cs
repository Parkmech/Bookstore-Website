//Parker Mecham, Section 1

using System;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext (DbContextOptions<BookStoreDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
