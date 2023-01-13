using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int sayi2;
            string ikili = "";
            Console.Write("sayi: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            sayi2 = sayi;
            while( sayi > 0)
            {
                ikili = (sayi % 2) + ikili;
                sayi = sayi / 2;
            }
            Console.Write(sayi2 + " onluk sayisinin ikili tabana cevrilmis hali = " + ikili);
        }
    }
}
