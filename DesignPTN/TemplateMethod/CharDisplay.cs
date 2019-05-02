using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private char Ch;

        public CharDisplay(char ch)
        {
            Ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(Ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }

    }
}
