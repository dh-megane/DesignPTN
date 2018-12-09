using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Constracut()
        {
            builder.makeTitle("Greeting");
            builder.makeString("朝から昼にかけて");
            builder.makeItems(new string[] { "およはようございます。", "こんにちは。" });
            builder.makeString("夜に");
            builder.makeItems(new string[] { "こんばんは", "おやすみなさい", "さようなら" });
            builder.close();
        }
    }
}
