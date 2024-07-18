using System;

namespace Faktoriyel_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // FAKTÖRİYEL DEĞERİNİ YAZIP SONUÇ ALABİLİRSİN.

            Console.WriteLine("{0}! = {1}", n, Matematik.Faktoriyel(n));
        }
    }
}
