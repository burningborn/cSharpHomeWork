using System;
using System.Collections.Generic;
using System.Text;


namespace HWcSharp_8
{

    class Rectangle : Figures, IDrawable
    {
        private string name;
        double heigth;
        double width;

        public Rectangle()
        {
            name = null;
            heigth = 0;
            width = 0;
        }
        public Rectangle(string _name, double a, double b)
        {
            name = _name;
            heigth = a;
            width = b;
        }
        public override double Square()
        {
            Console.WriteLine($" Square of Rectangle = {heigth * width}");
            return heigth * width;
        }

        public override double Perimeter()
        {
            Console.WriteLine($" Perimeter of Rectangle = {(heigth + width) * 2}");
            return (heigth + width) * 2;
        }
        public void Draw()
        {
         for (int i = 0; i < (int)heigth; i++)
            {
                for(int j = 0; j < (int)width; j++)
                {
                    Console.Write("*");
                }
                    Console.Write("\n");
            }
        }
    }
    class Circle : Figures
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
        public override double Square()
        {
            Console.WriteLine($" Square of Circle = {pi * radius * radius}");
            return pi * radius * radius;
        }
        public override double Perimeter()
        {
            Console.WriteLine($" Perimeter of Circle = {2 * pi * radius}");
            return 2 * pi * radius;
        }
    }
    class Squares : Figures, IDrawable
    {
        private string name;
        private double side;

        public Squares()
        {
            name = null;
            side = 0;
        }
        public Squares(string _name, double s)
        {
            name = _name;
            side = s;
        }
        public override double Square()
        {
            Console.WriteLine($" Square of Square = {side * side}");
            return side * side;
        }
        public override double Perimeter()
        {           
            Console.WriteLine($" Perimeter of Square = {side * 4}");
            return side * 4;
        }
        public void Draw()
        {
            for (int i = 0; i < (int)side; i++)
            {
                for (int j = 0; j < (int)side; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
    class Triangle : Figures
    {
        string name;
        double a;
        double b;
        double c;

        public Triangle()
        {
            name = null;
            a = b = c = 0;
        }
        public Triangle(string _name, double A, double B, double C)
        {
            name = _name;
            a = A;
            b = B;
            c = C;
        }

        public override double Square()
        {
            double p = (a + b + c) / 2;
            Console.WriteLine($" Square of Triangle = {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
            return p * (p - a) * (p - b) * (p - c);
        }
        public override double Perimeter()
        {
            Console.WriteLine($" Perimeter of Triangle = {a + b + c}");
            return a + b + c;
       }
    }
    class Parallelogram : Figures
    {
        private string name;
        private double heigth;
        private double width;
        private double bigAngle;
        private double littleAngle;

        public Parallelogram()
        {
            name = null;
            heigth = 0;
            width = 0;
            bigAngle = 100;
            littleAngle = 180 - bigAngle;
        }
        public Parallelogram(string _name, double a, double b, double BigAangle)
        {
            name = _name;
            heigth = a;
            width = b;
            bigAngle = BigAangle;
            littleAngle = 180 - bigAngle;
        }
        public override double Square()
        {
            Console.WriteLine($" Square of Parallelogram = {heigth * width}");
            return heigth * width;
        }
        public override double Perimeter()
        {
            Console.WriteLine($" Perimeter of Parallelogram = {(heigth + width) * 2}");
            return (heigth + width) * 2;
        }
    }
    class Trapezoid : Figures
    {
        private string name;
        private double bottom;  //Основание
        private double up;      // Верх
        private double heigth;  // Высота
        private double left;    // Левая сторрона
        private double right;   //Правая сторона

        public Trapezoid(string _name, double _bottom, double _up, double _heigth, double _left)
        {
            name = _name;
            if (left < heigth || left > Math.Sqrt(heigth * heigth + (bottom - up) + (bottom - up)))
            {
                bottom = up = heigth = left = right = -1;
                Console.WriteLine("It`s not right");
                name = "udefined";
            }
            else
            {
                Console.WriteLine("All right");

            }
            bottom = _bottom;  
            up = _up;
            heigth = _heigth;  
            left = _left;
            right = Math.Sqrt((bottom - up) * (bottom - up) + (heigth * heigth));
        }
        public override double Square()
        {
            Console.WriteLine($" Square of Trapezoid = {(bottom + up) / 2 * heigth}");
            return (bottom + up) / 2 * heigth;
        }
        public override double Perimeter()
        {
            Console.WriteLine($" Perimeter of Trapezoid = {bottom + up + left + right}");
            return bottom + up + left + right;
        }
    }
}

