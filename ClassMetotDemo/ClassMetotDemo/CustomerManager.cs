using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " added!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " deleted!");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("ID : " + customer.CustomerId);
                Console.WriteLine("First Name : " + customer.CustomerName);
                Console.WriteLine("Surname : " + customer.CustomerSurname);
            }
                

        }
    }
}
