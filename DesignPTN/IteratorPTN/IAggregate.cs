﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPTN;

namespace IteratorPTN
{
    public interface IAggregate
    {
        IIterator Iterator(int type);
    }
}