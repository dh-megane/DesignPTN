using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public abstract class Entry
    {
        public abstract string GetName();

        public abstract int GetSize();

        public virtual Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public void PrintList()
        {
            PrintList("");
        }

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return $"{ GetName() }({ GetSize() })";
        }

    }
}
