using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter8.Factory;

namespace Chapter8.ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<li>");
            builder.AppendLine(_caption);
            builder.AppendLine("<ul>");

            foreach (var item in _tray)
            {
                builder.AppendLine(item.MakeHTML());
            }

            builder.AppendLine("</ul>");
            builder.AppendLine("</li>");

            return builder.ToString();

        }
    }
}
