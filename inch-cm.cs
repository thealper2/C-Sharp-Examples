using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch, santim;
            const double x = 2.54;
            Console.Write("Inch : ");
            inch = Convert.ToDouble(Console.ReadLine());
            santim = inch * x;
            Console.Write(x + " inch = " + santim + " cm.");
        }
    }
}
