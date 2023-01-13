using System;
using System.IO;
namespace ConsoleApp1
{  
    class Program
    {
        static void Main(string[] args)
        {
            string klasor = @"c:\Windows";
            if(Directory.Exists(klasor))
            {
                Console.WriteLine("Aranan klasor bulundu.");
                Console.WriteLine("Alt klasor listesi: ");
                string[] altklasor = Directory.GetDirectories(klasor);
                foreach (string k in altklasor)
                    Console.WriteLine(k);
            }
        }
    }
}
