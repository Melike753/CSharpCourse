using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            // Bir interface hiçbir zaman newlenemez.
            // Amaç : Uygulamanın bağımlılıklarını minimalize etmek yani sıfıra indirmek.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            // Polimorfizm : Çok biçimlilik
            ICustomerDal[] customerDals = new ICustomerDal[3] {new  OracleCustomerDal(), new SqlServerCustomerDal(),new MySqlCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                Console.WriteLine("*************");
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer
            {
                FirstName = "Melike",
                Id = 1,
                LastName = "Dönmez",
                Address = "Ankara",
            });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demir",
                Departmant = "Computer Sciences"
            };

            personManager.Add(student);
        }
    }

    // Temel nesne oluşturur ve tüm nesneleri ondan implemente eder.
    // Soyut nesne : Tek başına hiçbir anlam ifade etmez.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string Address { get; set; }
    }
    class Student : IPerson
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }
    }
}