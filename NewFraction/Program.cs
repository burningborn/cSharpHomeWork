using System;
using NewFraction;

namespace NewFraction
{
    class Program
    {
        static void Main(string[] args)
        {          
            Fractions f = new Fractions(3, 4);           
            Console.Write("f - ");
            f.Display();
            int a = 10;
            Fractions f1 = f * a;
            Console.Write("f1 - ");
            f1.Display();           
            Fractions f2 = a * f;
            Console.Write("f2 - ");
            f2.Display();
            double d = 0.5;
            Fractions f3 = f + d;
            Console.Write("f3 - ");
            f3.Display();
            Console.WriteLine(f == f1);
            Console.WriteLine(f != f1);
        }
    }
}
