using StrategyPattern.Business;
using StrategyPattern.Strategies;

// Create shopping cart and add items
var cart = new ShoppingCart();
cart.AddItem(29.99m);
cart.AddItem(49.99m);

// Pay using iDEAL
cart.SetPaymentStrategy(new IdealPayment());
cart.Checkout();

// Pay using Credit Card
cart.SetPaymentStrategy(new CreditCardPayment("1234567890123456", "12/25"));
cart.Checkout();

// Pay using PayPal
cart.SetPaymentStrategy(new PayPalPayment("example@email.com"));
cart.Checkout();
