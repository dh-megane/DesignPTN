using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPTN;

namespace IteratorPTN
{
    public class BookShelf : IAggregate
    {
        private readonly ArrayList Books;
        private int Last;

        public BookShelf()
        {
            Books = new ArrayList();
            Last = 0;
        }

        public Book GetBookAt(int index)
        {
            return (Book)Books[index];
        }

        public void AppendBook(Book book)
        {
            Books.Add(book);
            Last += 1;
        }

        public int GetLength()
        {
            return Last;
        }

        public IIterator Iterator(int type)
        {
            IIterator it;
            if (type == 1)
            {
                it = new BookShelfIteratorAsc(this);
            }
            else
            {
                it = new BookShelfIteratorDesc(this);
            }

            return it;
        }
    }
}
