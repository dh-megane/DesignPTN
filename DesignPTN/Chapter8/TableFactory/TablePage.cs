using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter8.Factory;

namespace Chapter8.TableFactory
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author) { }

        public override string MakeHTML()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"<html><head><title>{ _title }</title></head>");
            builder.AppendLine("<body>");
            builder.AppendLine($"<h1>{ _title }</h1>");
            builder.AppendLine("<table width='80' border='3px'>");

            foreach(var item in _content)
            {
                builder.AppendLine($"<tr>{ item.MakeHTML() }</tr>");
            }

            builder.AppendLine("</table>");
            builder.AppendLine($"<hr><address>{ _author }</address>");
            builder.AppendLine("</body></html>");

            return builder.ToString();

        }
    }
}
