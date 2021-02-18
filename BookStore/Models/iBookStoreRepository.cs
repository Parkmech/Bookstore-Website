using System;
using System.Linq;

namespace BookStore.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
