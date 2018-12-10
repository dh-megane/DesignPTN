using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.ReadKey();
        }
    }
}
