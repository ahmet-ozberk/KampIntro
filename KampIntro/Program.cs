using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            double ondalikliSayi = 16.45;
            int sayisalVeri = 1453;
            bool dogruYanlis = false;

            if (dogruYanlis == true)
            {
                Console.WriteLine("Cevap doğru");
            }
            else {
                Console.WriteLine("Cevap Yanlış");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(sayisalVeri);
            Console.WriteLine(ondalikliSayi);
            Console.WriteLine(dogruYanlis);
        }
    }
}
