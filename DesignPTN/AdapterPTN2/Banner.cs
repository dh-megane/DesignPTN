using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPTN2
{
    public class Banner
    {
        private string Str;

        public Banner(string str)
        {
            Str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({Str})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{Str}*");
        }

    }
}
