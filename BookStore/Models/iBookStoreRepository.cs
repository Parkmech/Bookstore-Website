﻿//Parker Mecham, Section 1
//Repositiory
using System;
using System.Linq;

namespace BookStore.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
