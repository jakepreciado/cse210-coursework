using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", 101, 1200, 1),
            new Product("Keyboard", 102, 100, 2)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Smartphone", 201, 800, 1),
            new Product("Headphones", 202, 200, 1),
            new Product("Charger", 203, 25, 2)
        };
        Order order2 = new Order(customer2, products2);

        Address address3 = new Address("789 Oak St", "Los Angeles", "CA", "USA");
        Customer customer3 = new Customer("Michael Johnson", address3);
        List<Product> products3 = new List<Product>
        {
            new Product("Tablet", 301, 600, 1),
            new Product("Stylus Pen", 302, 50, 1),
            new Product("Tablet Case", 303, 40, 1)
        };
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine("\nPACKING LABEL:\n" + order1.GetPackingLabel());
        Console.WriteLine("\nSHIPPING LABEL:\n" + order1.GetShippingLabel());
        Console.WriteLine("\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine("\nPACKING LABEL:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nSHIPPING LABEL:\n" + order2.GetShippingLabel());
        Console.WriteLine("\n");

        Console.WriteLine("Order 3:");
        Console.WriteLine("Total Cost: $" + order3.CalculateTotalCost());
        Console.WriteLine("\nPACKING LABEL:\n" + order3.GetPackingLabel());
        Console.WriteLine("\nSHIPPING LABEL:\n" + order3.GetShippingLabel());
    }
}