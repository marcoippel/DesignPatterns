using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Business
{
    public class ShoppingCart
    {
        private IPaymentStrategy? _paymentStrategy;
        private readonly List<decimal> _items = new();

        public void AddItem(decimal price)
        {
            _items.Add(price);
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public decimal CalculateTotal()
        {
            return _items.Sum();
        }

        public void Checkout()
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Please select a payment method first!");
            }

            decimal total = CalculateTotal();
            _paymentStrategy.Pay(total);
        }
    }
}
