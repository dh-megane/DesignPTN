using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class CharDisplay : AbstractDisplay
    {
        private char _Ch;

        public CharDisplay(char ch)
        {
            this._Ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(_Ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
