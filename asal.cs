using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac, sayi;
            bool sonuc = true;
            Console.Write("Sayi: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(sayac = 2; sayac <= sayi-1; sayac++)
            {
                if(sayi % sayac == 0)
                {
                    sonuc = false;
                    break;
                }
            }
            if (sonuc == true)
            {
                Console.Write(sayi + " Asaldir.");
            }
            else
                Console.Write(sayi + " Asal degildir.");
        }
    }
}
