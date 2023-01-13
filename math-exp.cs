using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x in karesi: " + Math.Pow(x,2));
            Console.WriteLine("x in kupu: " + Math.Pow(x, 3));
            Console.WriteLine("x in karekoku: " + Math.Sqrt(x));
            Console.WriteLine("x in mutlak degeri: " + Math.Abs(x));
            Console.WriteLine("x-y kucuk olan: " + Math.Min(x, y));
            Console.WriteLine("x-y buyuk olan: " + Math.Max(x, y));
            Console.WriteLine("x in kucuk tamsayiya yuvarla: " + Math.Floor(x));
            Console.WriteLine("x in buyuk tamsayiya yuvarla: " + Math.Ceiling(x));
            Console.WriteLine("x in tamsayiya yuvarla: " + Math.Round(x));
            Console.WriteLine("logx: " + Math.Log10(x));
            Console.WriteLine("sinx: " + Math.Sin(x));
            Console.WriteLine("cosx: " + Math.Cos(x));
        }
    }
}
