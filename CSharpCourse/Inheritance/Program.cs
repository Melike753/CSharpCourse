using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalıtım -> Inheritance : Miras 

            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName ="Melike"}, new Student{ FirstName = "Derin"}, new Person{FirstName = "Osman"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }

        }

        // Bir sınıfın bir baba sınıfı olur.
        // Not: Bir sınıf tek bir sınıfı miras alabilir.
        // Classların tek başına bir anlamı vardır fakat interfacelerin tek başlarına anlamı yoktur.
        // İnterfaceler inheritance mantığı ile kullanılabildiği için genelde onu tercih et.
    }
}