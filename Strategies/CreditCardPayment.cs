using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Business;

namespace StrategyPattern.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private readonly string _cardNumber;
        private readonly string _expiryDate;

        public CreditCardPayment(string cardNumber, string expiryDate)
        {
            _cardNumber = cardNumber;
            _expiryDate = expiryDate;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"€{amount} paid using Credit Card ending with {_cardNumber[^4..]}");
            // Real credit card payment logic would go here
        }
    }
}
