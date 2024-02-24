using System;

namespace Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            // Customer customer = new Customer();
            // customer.City = "Tokat";
            // customer.Id = 4;
            // customer.FirstName = "Salih";
            // customer.LastName = "Yürek";
            //
            // Customer customer2 = new Customer
            // {
            //     Id = 2, City = "İstanbul",FirstName = "Derin",LastName = "Demiroğ"
            // };
            //
            // Console.WriteLine(customer2.FirstName);
            //
        }
    }
}