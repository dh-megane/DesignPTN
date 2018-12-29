using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8.Factory
{
    public abstract class Tray : Item
    {
        protected List<Item> _tray = new List<Item>();

        public Tray(string caption) : base(caption){ }

        public void Add(Item item)
        {
            _tray.Add(item);
        }
    }
}
