using Exercicios;
using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicios.Entities.Enums;
using Exercicios.Entities;

// EXERCICIOS
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client info
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(name, email, birthDate);

            // Order infos
            Console.WriteLine("");
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? \n");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus);

            for(int i = 0; i < n; i++)
            {
                // collecting product data
                Console.WriteLine($"Enter #{(i+1)} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                // have all necessary infos to a product
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("");
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine($"Client: {client}");
            
            Console.WriteLine("Order Items: ");
            Console.WriteLine(order);
        }
    }
}
