using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter8.Factory;

namespace Chapter8.TableFactory
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<td>");
            builder.AppendLine("<table style='width:100%;' border='1px' ><tr>");
            builder.AppendLine($"<td style='background:#CCCCCC; text-align:center;' " +
                $"colspan='{ _tray.Count }'><b>{ _caption }</b></td>");

            builder.AppendLine("</tr>");
            builder.AppendLine("<tr>");

            foreach(var item in _tray)
            {
                builder.AppendLine(item.MakeHTML());
            }

            builder.AppendLine("</tr></table>");
            builder.AppendLine("</td>");

            return builder.ToString();

        }
    }
}
