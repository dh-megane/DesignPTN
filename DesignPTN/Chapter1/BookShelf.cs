using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class BookShelf : IAggregate
    {
        private Book[] _books;

        public int Last { get; set; } = 0;

        public BookShelf(int maxsize)
        {
            this._books = new Book[maxsize];
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            this._books[Last] = book;
            Last++;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
