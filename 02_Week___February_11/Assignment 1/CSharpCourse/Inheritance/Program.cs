using System;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Salih"},
                new Student{FirstName = "Engin"},
                new Person{FirstName = "Derin"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    class Customer: Person
    {
        public string City { get; set; }
    }
    class Student: Person
    {
        public string Department { get; set; }
    }
}