using System;

namespace Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // InterfacesIntro();
            // Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleCustomerDal(), 
                new SqlServerCustomerDal(),
                new MysqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer{Id = 5,Address = "Tokat",FirstName = "Salih",LastName = "Yürek"});

            Student student = new Student
            {
                Id = 3,
                Department = "Computer Sciences",
                FirstName = "Krunoslav",
                LastName = "Simon"
            };
            
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    
}