public class Program
{
    static void Main(string[] args)
    {
    
        Product product1 = new Product("Laptop", "101", 800, 1);
        Product product2 = new Product("Mouse", "102", 25, 2);

        Product product3 = new Product("Smartphone", "201", 500, 1);
        Product product4 = new Product("Headphones", "202", 50, 2);

        
        Address addressUSA = new Address("123 Elm St", "Springfield", "IL", "USA");// Addresses
        Address addressCanada = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

  
        Customer customerUSA = new Customer("John Doe", addressUSA);// Customers
        Customer customerCanada = new Customer("Jane Smith", addressCanada);


        Order order1 = new Order(customerUSA, new List<Product> { product1, product2 });// Orders
        Order order2 = new Order(customerCanada, new List<Product> { product3, product4 });

       
        Console.WriteLine("Order 1 (USA):");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}");

        Console.WriteLine("\nOrder 2 (Canada):");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal()}");
    }
}