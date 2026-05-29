using System;
using System.Collections.Generic;

namespace OnlineOrdering;

class Program
{
     
        static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System!\n");

        // 1. Create an address for the customer
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA", true);

        //I added a second address to test the international shipping cost logic
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada", false);

    // 2. Create a customer with that address
    Customer customer1 = new Customer("John Doe", address1);
    Customer customer2 = new Customer("Jane Smith", address2);

    // 3. Create an order for the customer and I changed it to customer2 to test the international shipping cost
    Order order = new Order(customer1);

    // 4. Add products to the order
    Product product1 = new Product("Laptop", "P100", 999.99, 1);
    Product product2 = new Product("Mouse", "M200", 49.99, 2);
    
    order.AddProduct(product1);
    order.AddProduct(product2);
        
        // 5. Display the required outputs
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order.CalculateTotalCost():F2}");
    }
}
    