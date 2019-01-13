using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;

        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this._bookShelf = bookShelf;
            this._index = 0;
        }

        public Boolean HasNext()
        {
            if(_index < _bookShelf.Last)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Object Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
