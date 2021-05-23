using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmeni = "Mustafa Murat Çoşkun";
            kurs2.IzlenmeOrani = 73;

            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "PYTHON";
            kurs1.Egitmeni = "Ahmet Özberk";
            kurs1.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.IzlenmeOrani);
            }

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmeni);
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmeni);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
