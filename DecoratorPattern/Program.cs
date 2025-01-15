using DecoratorPattern.Business;
using DecoratorPattern.Decorators;

ICoffee mijnKoffie = new SimpleCoffee();
Console.WriteLine($"Bestelling: {mijnKoffie.GetDescription()}");
Console.WriteLine($"Kosten: €{mijnKoffie.GetCost()}");

// Voeg melk toe
mijnKoffie = new MilkDecorator(mijnKoffie);
Console.WriteLine($"Bestelling: {mijnKoffie.GetDescription()}");
Console.WriteLine($"Kosten: €{mijnKoffie.GetCost()}");

// Voeg suiker toe
mijnKoffie = new SugarDecorator(mijnKoffie);
Console.WriteLine($"Bestelling: {mijnKoffie.GetDescription()}");
Console.WriteLine($"Kosten: €{mijnKoffie.GetCost()}");


// Voeg melk en suiker toe
ICoffee mijnKoffie2 = new SimpleCoffee();
mijnKoffie2 = new MilkDecorator(mijnKoffie2);
mijnKoffie2 = new SugarDecorator(mijnKoffie2);
Console.WriteLine($"Bestelling: {mijnKoffie2.GetDescription()}");
Console.WriteLine($"Kosten: €{mijnKoffie2.GetCost()}");