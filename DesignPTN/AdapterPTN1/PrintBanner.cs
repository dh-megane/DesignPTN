using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPTN1
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str) : base(str){ }

        public void PrintWeak()
        {
            base.ShowWithParen();
        }

        public void PrintStrong()
        {
            base.ShowWithAster();
        }
    }
}
