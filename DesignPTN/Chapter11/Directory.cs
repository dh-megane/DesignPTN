using System;
using System.Collections;

namespace Chapter11
{
    public class Directory : Entry
    {
        private readonly string _name;
        private readonly ArrayList _directory = new ArrayList();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            var size = 0;
            var it = _directory.GetEnumerator();
            while (it.MoveNext())
            {
                size += ((Entry)it.Current).GetSize();
            }

            return size;

        }

        public override Entry Add(Entry entry)
        {
            _directory.Add(entry);
            return this;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{_name}");
            var it = _directory.GetEnumerator();
            while (it.MoveNext())
            {
                var entry = (Entry)it.Current;
                entry?.PrintList($"{prefix}/{_name}");
            }
        }
    }
}
