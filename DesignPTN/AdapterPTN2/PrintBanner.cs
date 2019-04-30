using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPTN2
{
    public class PrintBanner : Print
    {
        private Banner banner;

        public PrintBanner(string str)
        {
            banner = new Banner(str);
        }

        public override void PrintWeak()
        {
            banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}
