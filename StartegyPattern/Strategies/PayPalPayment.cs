using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Business;

namespace StrategyPattern.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        private readonly string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"€{amount} paid using PayPal account: {_email}");
            // Real PayPal payment logic would go here
        }
    }
}
