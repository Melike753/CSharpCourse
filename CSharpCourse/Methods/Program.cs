using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();

            Add2(20, 30);
            var result = Add2(55, 45);
            Console.WriteLine(result);

            Console.WriteLine(Add3());

            int toplam = Add3(20);
            Console.WriteLine(toplam);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add4(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            // Parametrenin önüne ref yazılmak zorunda.
            var result3 = Add6(ref number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add7(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Console.ReadLine();
        }

        // Metotlar genelde kendini tekrarlamamak için kullanılır.
        // Don't repeat yourself !
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int x, int y)
        {
            return x + y;
        }
       
        // Default parametreli metotlar
        // Default değerler her zaman metodun en sonunda olmalı.
        static int Add3(int x = 10, int y = 20)
        {
            return (x + y);
        }
        static int Add4(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // Parametrenin önüne ref yazılmak zorunda.
        static int Add6(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // ref keywordü , değer tiplerinin referans tip gibi kullanılmasını sağlar.
        // ref alternatifi bir de out keywordü vardır.
        // farkı ref te değer atamadan (number1 e) gönderemezsin fakat out da değer atamadan gönderebilirsin.
        static int Add5(out int number1, int number2)
        {
            number1 = 30; // out da yazılmak zorunda.
            return number1 + number2;
        }

        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        // Params Keyword ile Çalışmak
        static int Add7(params int[] numbers)
        {
            return numbers.Sum();
        }
        // Not : paramslı parametre metotun son parametresi olmak zorundadır. Fakat öncesine farklı parametreler eklenebilir.
    }
}