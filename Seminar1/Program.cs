namespace Seminar1;

internal class Program
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new() { Name = "Dima" },
            new() { Name = "Petya" },
            new() { Name = "Vasya" },
        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 5; i++)
            factory.AddCar();

        Console.WriteLine("Before");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();

        Console.Write("\nAfter");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
    }
}
