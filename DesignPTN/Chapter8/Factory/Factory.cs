using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8.Factory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;

            try
            {
                factory = (Factory)Activator.CreateInstance(Type.GetType(className));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return factory;

        }

        public abstract Link CreateLink(string caption, string url);

        public abstract Tray CreateTray(string caption);

        public abstract Page CreatePage(string title, string author);

    }
}
