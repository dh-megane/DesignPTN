﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    public abstract class Builder
    {
        public abstract void makeTitle(string title);

        public abstract void makeString(string str);

        public abstract void makeItems(string[] items);

        public abstract void close();
    }
}
