using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8.Factory
{
    public abstract class Page
    {
        protected string _title;

        protected string _author;

        protected List<Item> _content = new List<Item>();

        public Page(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public void Add(Item item)
        {
            _content.Add(item);
        }

        public void Output()
        {
            try
            {
                string fileName = _title + ".html";

                StreamWriter writer = new StreamWriter(fileName);
                writer.Write(this.MakeHTML());
                writer.Close();

                Console.WriteLine($"({fileName}を作成しました。)");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public abstract string MakeHTML();

    }
}
