using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class StringDisplay : AbstractDisplay
    {
        private string _string;

        private int _width;

        public StringDisplay(string str)
        {
            this._string = str;
            this._width = Encoding.GetEncoding("Shift_JIS").GetByteCount(str);
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{ _string }|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");

            for(var i = 0; i < _width; i++ )
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}
