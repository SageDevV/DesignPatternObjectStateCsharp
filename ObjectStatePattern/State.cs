﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStatePattern
{
    public abstract class State
    {
        protected Context _context;
        public void SetContext(Context context)
        {
            _context = context;
        }
        public abstract void Handle1();

        public abstract void Handle2();
    }
}
