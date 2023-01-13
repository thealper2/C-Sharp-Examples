using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, hipo, aci;
            Console.Write("a acisi: ");
            aci = Convert.ToDouble(Console.ReadLine());
            Console.Write("a uzunlugu: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b uzunlugu: ");
            b = Convert.ToDouble(Console.ReadLine());
            hipo = Math.Sqrt(a*a + b*b);
            h = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(aci * Math.PI / 180));
            Console.WriteLine("Hipotenus = " + hipo + "\nH = " + h);
        }
    }
}
