using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Prgramlamaya başlangıç için temel kurs";

            //arrayler-diziler
            string[] kurslar = new string[] {
                "Yazılım geliştirici yetiştirme kampı",
                 "Prgramlamaya başlangıç için temel kurs",
                 "Java","Python"
            };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------------------------------------------------------");

            foreach (var i in kurslar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
