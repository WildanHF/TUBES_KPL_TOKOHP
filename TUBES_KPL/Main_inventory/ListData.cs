﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_inventory
{
    internal class ListData<T1, T2>
    {
        internal void PrintData()
        {
            throw new NotImplementedException();
        }

        public static implicit operator ListData<T1, T2>(ListData<string, int, int, int> v)
        {
            throw new NotImplementedException();
        }
    }
}