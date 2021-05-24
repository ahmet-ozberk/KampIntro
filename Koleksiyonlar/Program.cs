using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Ahmet","Aslı","Ali","Firuze" };
            //Console.WriteLine(isimler[0]);
            Console.WriteLine("________________________________");
            List<object> isimler2 = new List<object> { "Ahmet", "Aslı", "Ali", "Firuze",15,4.6 };
            foreach (var i in isimler2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
