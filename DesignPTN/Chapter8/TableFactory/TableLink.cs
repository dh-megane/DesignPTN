using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter8.Factory;

namespace Chapter8.TableFactory
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url) { }

        public override string MakeHTML()
        {
            return $"<td><a href='{ _url }'>{ _caption }</a></td>\n";
        }
    }
}
