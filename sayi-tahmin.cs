using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, rs;
            Random ras = new Random();
            rs = ras.Next(1, 10);
            do
            {
                Console.Write("Sayi giriniz: ");
                s = Convert.ToInt32(Console.ReadLine());
                if (s > rs)
                {
                    Console.WriteLine("Daha kucuk bir sayi giriniz. !");
                }
                if (s < rs)
                {
                    Console.WriteLine("Daha buyuk bir sayi giriniz. !");
                }
            } while (s != rs);
            Console.Write("Tebrikler ! " + s + " dogru tahmin.");
        }
    }
}
