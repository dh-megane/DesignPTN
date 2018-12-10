using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str) : base(str)
        {

        }

        public void PrintWeak()
        {
            ShowWithParen();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}
