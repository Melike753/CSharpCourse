using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Melike";

            Console.WriteLine(sentence.Length);

            Console.WriteLine(sentence.EndsWith("e"));
            Console.WriteLine(sentence.StartsWith("My name"));

            Console.WriteLine(sentence.IndexOf("name")); // Bir metin içinde bir ifadeyi aramak için kullanılır , bulamazsa -1 döner.

            Console.WriteLine(sentence.IndexOf(" ")); // Bulduğu ilk boşluğu sayar.
            Console.WriteLine(sentence.LastIndexOf(" ")); // Sondan ilk bulduğu boşluğu sayar.

            Console.WriteLine(sentence.Insert(0, "Hello, "));

            Console.WriteLine(sentence.Substring(3, 4));

            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.ToUpper());

            Console.WriteLine(sentence.Replace(" ", "-"));

            Console.WriteLine(sentence.Remove(2));

            Console.ReadLine();
        }

        private static void Intro()
        {
            // string : Metinsel verileri tutmak için kullanılan değişken tipidir.
            // stringler char arraydir.

            string city = "Ankara";

            Console.WriteLine(city);
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}