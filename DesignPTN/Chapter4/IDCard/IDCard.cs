using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter4.Framework;

namespace Chapter4.IDCard
{
    public class IDCard : Product
    {
        private string Owner { get; }

        public IDCard(string owner)
        {
            Console.WriteLine($"{ owner }のカードを作ります。");
            this.Owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{ Owner }のカードを使います。");
        }

    }
}
