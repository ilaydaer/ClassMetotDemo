using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Ad1";
            customer1.CustomerSurname = "Soyad1";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Ad2";
            customer2.CustomerSurname = "Soyad2";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Ad3";
            customer3.CustomerSurname = "Soyad3";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);
            Console.WriteLine("");
            Console.WriteLine("Customers Listed!");
                
        }

    }
}
