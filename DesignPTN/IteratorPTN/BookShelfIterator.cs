using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPTN
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf BookShelf;
        private int Index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            BookShelf = bookShelf;
        }

        public bool HasNext()
        {
            return BookShelf.GetLength() != Index;
        }

        public Object Next()
        {
            return BookShelf.GetBookAt(Index++);
        }
    }
}
