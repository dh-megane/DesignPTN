using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Director _director;

            if (args.Length != 1)
            {
                return;
            }

            if (args[0].Equals("plain"))
            {
                TextBuilder textbuilder = new TextBuilder();
                _director = new Director(textbuilder);
                _director.Constracut();
                string result = textbuilder.getResult();
                Console.WriteLine(result);
            }
            else if(args[0].Equals("html"))
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                _director = new Director(htmlbuilder);
                _director.Constracut();
                string filename = htmlbuilder.getResult();
                Console.WriteLine($"{ filename }が作成されました。");
            }
            else
            {
                return;
            }

            Console.ReadKey();
        }
    }
}
