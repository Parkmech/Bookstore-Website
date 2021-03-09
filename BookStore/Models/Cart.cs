using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int quantity)
        {
            CartLine line = Lines
                .Where(b => b.Book.bookId == book.bookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity

                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }


        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.bookId == book.bookId);


        public virtual void Clear() => Lines.Clear();

        public float ComputeTotalSum() => Lines.Sum(x => x.Book.Price * x.Quantity);
        

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
