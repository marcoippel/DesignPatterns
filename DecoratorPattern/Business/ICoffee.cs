﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Business
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
