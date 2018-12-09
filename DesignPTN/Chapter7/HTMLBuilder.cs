using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter7
{
    public class HTMLBuilder : Builder 
    {
        private string _FileName;
        private StreamWriter _writer;

        public override void makeTitle(string title)
        {
            _FileName = title + ".html";
            try
            {
                _writer = new StreamWriter(_FileName, false);
            }
            catch(IOException ex)
            {
                ex.StackTrace.ToString();
            }

            _writer.WriteLine($"<html><head><title>{ title }</title></head><body>");
            _writer.WriteLine($"<h1>{ title }</h1>");

        }

        public override void makeString(string str)
        {
            _writer.WriteLine($"<p>{ str }</p>");
        }

        public override void makeItems(string[] items)
        {
            _writer.WriteLine("<ul>");
            foreach(var item in items)
            {
                _writer.WriteLine($"<li>{ item }</li>");
            }
            _writer.WriteLine("</ul>");
        }

        public override void close()
        {
            _writer.WriteLine("</body></html>");
            _writer.Close();
        }

        public String getResult()
        {
            return _FileName;
        }
    }
}
