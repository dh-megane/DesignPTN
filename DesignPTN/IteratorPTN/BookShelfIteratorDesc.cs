using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPTN
{
    public class BookShelfIteratorDesc : IIterator
    {
        private BookShelf BookShelf;
        private int Index;

        public BookShelfIteratorDesc(BookShelf bookShelf)
        {
            BookShelf = bookShelf;
            Index = BookShelf.GetLength() - 1;
        }

        public bool HasNext()
        {
            return -1 != Index;
        }

        public Object Next()
        {
            return BookShelf.GetBookAt(Index--);
        }
    }
}
