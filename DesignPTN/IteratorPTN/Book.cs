using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPTN
{
    public class Book
    {
        private string Name { set; get; }

        public Book(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
