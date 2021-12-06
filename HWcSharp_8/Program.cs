using System;


namespace HWcSharp_8
{
    abstract class Figures
    {
        public abstract double Square();
        public abstract double Perimeter();

    }
    class Rect : Figures
    {
        double heigth;
        double width;

        public Rect()
        {
            heigth = 0;
            width = 0;
        }
        public Rect(double a, double b)
        {
            heigth = a;
            width = b;
        }
        public double Heigth
            {
                get{ return heigth; }
                set{ heigth = value; } 
            }
        public override double Square()
        {
            return heigth * width;
        }
        public override double Perimeter()
        {
            return (heigth + width) * 2;
        }

    }
    class Circle
    {
        private string name;
        private static double pi = 3.14;
        private double radius;
        public Circle()
        {
            name = null;
            radius = 0;
        }
        public Circle(string _name, double R)
        {
            name = _name;
            radius = R;
        }
        public double Radius
        {
            get{ return radius; }
            set{ radius = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Radius = {radius}");
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Rect fourAngle = new Rect(3, 4);
        //fourAngle
        Circle C = new Circle("Krug", 3.5);
       
    }
}
