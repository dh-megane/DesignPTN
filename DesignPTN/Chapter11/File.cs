using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class File : Entry
    {
        private readonly string _name;
        private readonly int _size;

        public File(string name, int size)
        {
            this._name = name;
            this._size = size;

        }

        public override string GetName()
        {
            return this._name;
        }

        public override int GetSize()
        {
            return this._size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{ prefix }/{this}");
        }
    }
}