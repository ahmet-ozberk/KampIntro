using System;

namespace Dicts
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> sozluk1 = new MyDict<int, string>();
            sozluk1.Ekle(1,"Bir");
            sozluk1.Ekle(2,"İki");
            sozluk1.Ekle(3,"Üç");
            Console.WriteLine(sozluk1.Boyut);
        }
    }
}
