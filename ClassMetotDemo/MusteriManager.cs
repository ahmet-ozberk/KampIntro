using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(string ad, string soyad,int musteriNo) {
            Musteri musteri = new Musteri();
            musteri.Ad = ad;
            musteri.Soyad = soyad;
            musteri.MusteriNo = musteriNo;
            Console.WriteLine("\n\n" + ad +" "+soyad+" müşterisi eklendi.");
        }

        public void MusteriListele(Musteri[] musteri) {
            Console.WriteLine("\n\nMüşteri Listesi\n");
            foreach (Musteri i in musteri)
            {
                Console.WriteLine("Müşteri No: "+i.MusteriNo +"\nMüşteri Ad:" +i.Ad +"\nMüşteri Soyad:"+ i.Soyad);
                Console.WriteLine("________________________");
            }
        }

        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine("\n\n"+musteri.MusteriNo+" müşteri numaralı "+musteri.Ad+" başarıyla silindi.");
        }
    }
}
