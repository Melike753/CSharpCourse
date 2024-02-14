using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri kümesini dolaşmak için kullandığımız yapılara döngü denir.

            // ForLoop();

            // WhileLoop();

            // DoWhileLoop();

            // ForEachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; // Performansı arttırmak için.
                }
            }
            return result;
        }

        // Dizi temelli dataların dolaşılması için kullanılır.
        private static void ForEachLoop()
        {
            string[] students = new string[] { "Engin", "Derin", "Salih" };
            // student : Takma isim
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}