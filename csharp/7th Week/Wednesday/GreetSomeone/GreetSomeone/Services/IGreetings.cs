﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Services
{
    public interface IGreetings
    {
        string GetName();
        void SetName(string name);
    }
}
