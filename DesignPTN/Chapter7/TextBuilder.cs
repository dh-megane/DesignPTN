using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();

        public override void makeTitle(string title)
        {
            buffer.Append("===========================\n");
            buffer.Append($"『 { title } 』\n");
            buffer.Append("\n");
        }

        public override void makeString(string str)
        {
            buffer.Append($"■ { str }\n");
            buffer.Append("\n");
        }

        public override void makeItems(string[] items)
        {
            foreach(var item in items)
            {
                buffer.Append($" ・{ item }\n");
            }
            buffer.Append("\n");
        }

        public override void close()
        {
            buffer.Append("===========================\n");
        }

        public String getResult()
        {
            return buffer.ToString();
        }
    }
}
