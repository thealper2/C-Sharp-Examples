using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, d;
            Console.Write("a degeri: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b degeri: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c degeri: ");
            c = Convert.ToDouble(Console.ReadLine());
            d = b * b - 4 * a * c;
            if(d<0)
            {
                Console.Write("Sanal kok var.");
            }
            else if(d == 0)
            {
                x1 = -b / 2 * a;
                Console.Write("Tek kok var: " + x1);
            }
            else
            {
                x1 = -b - Math.Sqrt(d) / 2 * a;
                x2 = -b + Math.Sqrt(d) / 2 * a;
                Console.Write("Cifte kok var.\nx1 = " + x1 + "\nx2 = " + x2);
            }
        }
    }
}
