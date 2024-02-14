using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 12;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            Console.WriteLine(number == 12 ? "Number is 12" : "Number is not 12");

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20 or 30");
                    break;
            }

            // Kodu güzelleştirmek, daha okunaklı hale getirmek için Ctrl + K + D yap.

            var number2 = 20;

            if (number2 >= 0 && number2 <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number2 > 100 && number2 <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number2 > 200 || number2 < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            if (true)
            {
                if (true)
                {
                    Console.WriteLine("İç içe if örneği yapıldı!");
                }
            }

            Console.ReadLine(); // Uygulamanın kapanmasını önler.
        }
    }
}