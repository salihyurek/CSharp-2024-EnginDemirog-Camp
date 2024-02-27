using System;

namespace Interfaces

{
    class Program
    {
        static void Main(string[] args)
        {
            // intefaces new lenemez
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
        }
    }

    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void Update();
    }
    
    // intheritance, class larda kullanılır. // implements, interface lerde kullanılır 
    class CustomerManager: IPersonManager
    {
        public void Add()
        {
            // Müşteri Ekleme Kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager: IPersonManager
    {
        public void Add()
        {
            // Personel Ekleme Kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
