using System;

namespace OdevTrial
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();
            Product p4 = new Product();
            //--------------------------------------
            p1.urunAdi = "Bilgisayar";
            p1.urunSayisi = 73;

            p2.urunAdi = "Monitör";
            p2.urunSayisi = 41;

            p3.urunAdi = "Klavye";
            p3.urunSayisi = 60;

            p4.urunAdi = "Barbie ebek";
            p4.urunSayisi = 123;

            Product[] products = new Product[] { p1, p2, p3, p4 };
            Console.WriteLine(p1.urunAdi);
            Console.WriteLine("\nFor Döngüsü");
            //_____________For Döngüsü________________________
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adı: "+ products[i].urunAdi+"| Ürün Sayısı: "+ products[i].urunSayisi);
            }
            Console.WriteLine("\nFor Each Döngüsü");
            //_____________ForEach Döngüsü________________________
            foreach (Product urun in products)
            {
                Console.WriteLine("Ürün adı: "+urun.urunAdi+ "| Ürün Sayısı: "+urun.urunSayisi);
            }
            Console.WriteLine("\nWhile Döngüsü");
            //_____________While Döngüsü________________________
            int f = 0;
            while (f < products.Length)
            {
                Console.WriteLine("Ürün adı: "+ products[f].urunAdi+ "| Ürün Sayısı: "+ products[f].urunSayisi);
                f++;
            }
        }
    }
}

class Product
{
    public string urunAdi { get; set; }
    public int urunSayisi { get; set; }
}