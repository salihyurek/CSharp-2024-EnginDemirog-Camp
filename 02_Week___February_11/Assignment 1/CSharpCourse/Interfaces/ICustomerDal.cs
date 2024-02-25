using System;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }
    
    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }
    
    class MysqlCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql Added");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}