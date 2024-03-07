using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Customer
    {

        public string CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public Customer()
        {
            CustomerId = "C000";
            Name = "Unknown";
            Age = 0;
            Phone = "N/A";
            City = "N/A";
        }

        public Customer(string customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
        }

        ~Customer()
        {
            Console.WriteLine($"Customer {Name} with ID {CustomerId} has been removed.");
            Console.Read();
        }
    }

    class Question04
    {
        static void Main()
        {
            Customer customer1 = new Customer("cs1234", "divya", 08, "9652872010", "Vizag");
            customer1.DisplayCustomer();

            Customer customer2 = new Customer();
            customer2.DisplayCustomer();
            


        }
    }

}

