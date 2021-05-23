using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri m1 = new Musteri();
            m1.Ad = "Ahmet";
            m1.Soyad = "Özberk";
            m1.MusteriNo = 2757;

            Musteri m2 = new Musteri();
            m2.Ad = "Zeynep";
            m2.Soyad = "Kır";
            m2.MusteriNo = 814;

            Musteri m3 = new Musteri();
            m3.Ad = "Jhonny";
            m3.Soyad = "S";
            m3.MusteriNo = 3131;
            Musteri[] musteriler = {m1,m2,m3 };
           
            musteriManager.MusteriEkle("Salih","Gültekin",657);
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSil(m3);

        }
    }
}
