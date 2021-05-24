using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string> ();
            isimler.Add("Ahmet");
            isimler.Add("Aslı");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("____________________________");
            isimler.Add("Feyyaz");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
