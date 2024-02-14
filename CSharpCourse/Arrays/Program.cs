using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            // Arraylar : Aynı tipteki değişkenleri tek bir noktada tek bir değişkenle yönetip ona hızlıca ulaşma , onu döngüyle gezme ihtiyacında arrraylardan yararlanılır.
            string[] students1 = { student1, student2, student3 };

            string[] students = new string[3];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            foreach (string student in students1)
            {
                Console.WriteLine(student);
            }

            string[] students2 = new string[3] { "Ayşe", "Fatma", "Ali" };

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }

            // Koleksiyonlar arrayların iyileştirilmiş halidir.

            // Çok Boyutlu Diziler
            string[,] regions = new string[5, 3] // 5 satır 3 sütun
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            // regions[0, 0] = "İstanbul";

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("*************");
            }

            Console.ReadLine();
        }
    }
}