using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Business;

namespace StrategyPattern.Strategies
{
    internal class IdealPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"€{amount} paid using iDEAL");
            // Real iDEAL payment logic would go here
        }
    }
}
