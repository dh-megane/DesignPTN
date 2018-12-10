using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class Banner
    {
        private string _str;

        public Banner(string str)
        {
            this._str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({ _str })");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{ _str }*");
        }
    }
}
