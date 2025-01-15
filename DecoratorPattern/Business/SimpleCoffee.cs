using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Business
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Gewone koffie";
        }

        public double GetCost()
        {
            return 2.00;
        }
    }
}
