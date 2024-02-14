using System;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // Ekrana metni yazar.

            // Value Types
            int number1 = 10; // 32 bit
            Console.WriteLine(number1);
            Console.WriteLine("Number1 is {0}", number1);

            long number2 = 2147483648; // 64 bit
            Console.WriteLine("Number2 is {0}", number2);

            short number3 = 32000; // 16 bit
            Console.WriteLine("Number3 is {0}", number3);

            byte number4 = 255; // 8 bit
            Console.WriteLine(number4);

            bool condition = true;
            Console.WriteLine(condition);

            char character = 'a';
            Console.WriteLine((int)character); // ASCII sayısal karşılığı
            Console.WriteLine(character);

            // string : karakter dizisidir.

            double number5 = 100; // 64 bit
            Console.WriteLine(number5);

            double number6 = 100.852;
            Console.WriteLine(number6);

            // decimal daha hassastır. Ondalık sayı tutar.

            decimal number7 = 14.7896422365589855M; // Sonuna m veya M konulmalıdır.
            Console.WriteLine(number7);

            // enum : 
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(Days.Monday);

            var number8 = 13; // değişken tanımlamak için kullanılır. 
            var harf = 'M'; // verilen değere göre türü değişir.

            Console.ReadLine(); // Ekrana basmamızı istiyor. Ekranı bekletiyor.
        }
    }
    enum Days
    {
        // enum sabitleri
        Monday, Tuesday, Wednesday = 10, Thursday, Friday, Saturday, Sunday
    }
}