public class Program
{
    public static void Main(string[] args)
    {
        // Address creation
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Maple Rd", "Othertown", "ON", "Canada");

        // Customer creation
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Product creation
        Product product1 = new Product("Laptop", "A001", 999.99, 1);
        Product product2 = new Product("Mouse", "A002", 49.99, 2);
        Product product3 = new Product("Keyboard", "A003", 79.99, 1);
        Product product4 = new Product("Monitor", "A004", 199.99, 2);
        Product product5 = new Product("Printer", "A005", 149.99, 1);

        // Order creation
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order information
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackagingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}