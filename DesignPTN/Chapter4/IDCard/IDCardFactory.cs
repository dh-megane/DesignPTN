using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter4.Framework;

namespace Chapter4.IDCard
{
    public class IDCardFactory : Factory
    {
        private List<IDCard> Owners { get; } = new List<IDCard>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            Owners.Add((IDCard)product);
        }

    }
}
