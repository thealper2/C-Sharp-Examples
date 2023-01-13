using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Alper Karaca";
            Console.WriteLine("Bosluk sil: " + metin.Trim());
            Console.WriteLine("kucult: " + metin.ToLower());
            Console.WriteLine("buyult: " + metin.ToUpper());
            Console.WriteLine("Karakter sayisi: " + metin.Length);
            Console.WriteLine("3.karakterden sonrasini sil: " + metin.Remove(3));
            Console.WriteLine("2.krakterden sonra 2 karakter sil: " + metin.Remove(2, 2));
            Console.WriteLine("per -> rep: " + metin.Replace("per", "rep"));
        }
    }
}
