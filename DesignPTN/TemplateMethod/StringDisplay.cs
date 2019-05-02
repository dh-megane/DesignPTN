using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string String { set; get; }

        private int Width { set; get; }

        public StringDisplay(string str)
        {
            String = str;
            Encoding encShiftJis = Encoding.GetEncoding("Shift_JIS");
            Width = encShiftJis.GetByteCount(str);
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{String}|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
