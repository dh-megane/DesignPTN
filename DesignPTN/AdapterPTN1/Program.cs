using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPTN1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint print = new PrintBanner("文字列");
            print.PrintWeak();
            print.PrintStrong();

            Console.ReadKey();
        }
    }
}
