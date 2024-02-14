using System;

namespace Classes
{
    // Classlar bizim yapmak istediğimiz işlemleri gruplara ayırmak için kullanılır. Temel anlamda bir gruplama yapar.
    class Program
    {
        static void Main(string[] args)
        {
            // Class örneği oluşturma
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();

            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();

            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Melike";
            customer.LastName = "Dönmez";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Dönmez"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}