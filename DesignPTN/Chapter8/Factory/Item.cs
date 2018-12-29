using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8.Factory
{
    public abstract class Item
    {
        protected string _caption;

        public Item(string caption)
        {
            this._caption = caption;
        }

        public abstract string MakeHTML();

    }
}
