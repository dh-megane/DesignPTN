using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter8.Factory;

namespace Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("Usage: Main class.name.of.ConcreateFactory");
                Console.WriteLine("Example1: Main listFactory.ListFactory");
                Console.WriteLine("Example2: Main tableFactory.TableFactory");
                return;
            }

            Factory.Factory factory = Factory.Factory.GetFactory(args[0]);

            Link asahi = factory.CreateLink("朝日新聞", "http://www.asahi.com/");
            Link yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

            Link us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.CreateLink("Excite", "http://www.excite.com/");
            Link google = factory.CreateLink("Google", "http://www.google.com/");

            Tray trayNews = factory.CreateTray("新聞");
            trayNews.Add(asahi);
            trayNews.Add(yomiuri);

            Tray trayYahoo = factory.CreateTray("Yahoo!");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            Tray traySearch = factory.CreateTray("サーチエンジン");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            Page page = factory.CreatePage(args[0].Split('.')[1], "結城 浩");
            page.Add(trayNews);
            page.Add(traySearch);
            page.Output();

            Console.ReadKey();

        }
    }
}
