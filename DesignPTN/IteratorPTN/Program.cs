using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPTN
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book("JAVA");
            Book Book2 = new Book("C#");
            Book Book3 = new Book("PHP");
            Book Book4 = new Book("Scala");

            BookShelf bookShelf = new BookShelf();
            bookShelf.AppendBook(Book1);
            bookShelf.AppendBook(Book2);
            bookShelf.AppendBook(Book3);
            bookShelf.AppendBook(Book4);

            var iterator = bookShelf.Iterator(2);
            while (iterator.HasNext())
            {
                Book book = (Book)iterator.Next();
                Console.WriteLine(book.GetName());

            }

            Console.ReadKey();
        }
    }
}
