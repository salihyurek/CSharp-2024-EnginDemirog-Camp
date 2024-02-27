using System;

namespace Concructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id = 1,FirstName = "Salih",LastName = "Yürek",City = "Tokat"};

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            
            
            Console.WriteLine(customer2.FirstName);

            // Method(1,"sfsfdf","sdfs","sdfsdfs");
        }

        static void Method(int Id, string firstName, string lastName, string city)
        {
            
        }
        
    }

    class Customer
    {
        public Customer()
        {
            
        }
        
        // default Constructor
        public Customer(int id,string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            // Console.WriteLine("Kurucu blok çalıştı");
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}